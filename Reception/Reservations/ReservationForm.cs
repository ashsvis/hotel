using Model;
using System.Linq;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace Reception
{
    public partial class ArrivalForm : Form
    {
        //счетчик режима обновления
        private int updating;
        private readonly Hotel _hotel;
        private Room _room;
        private Dictionary<Room, TreeNode> _index = new Dictionary<Room, TreeNode>();

        public Reservation Data { get; set; }

        public ArrivalForm(Hotel hotel)
        {
            InitializeComponent();
            _hotel = hotel;
            ResetFilters();
        }

        private void BuildTree()
        {
            _index.Clear();
            try
            {
                tvRooms.AfterSelect -= tvRooms_AfterSelect;
                tvRooms.BeginUpdate();
                tvRooms.Nodes.Clear();
                // добавим корневой узел
                var hotelNode = new FloorTreeNode("Гостиница");
                tvRooms.Nodes.Add(hotelNode);
                // сформируем группы номеров по этажам
                foreach (var floors in _hotel.Rooms.OrderBy(f => f.Floor).GroupBy(f => f.Floor))
                {
                    // добавляем узы этажей
                    var floorNode = new TreeNode(string.Format($"{floors.Key} этаж"));
                    hotelNode.Nodes.Add(floorNode);
                    foreach (var categories in floors.GroupBy(c => c.IdCategory).OrderBy(c => _hotel.Categories[c.Key].NameCategory))
                    {
                        var categoryNode = new TreeNode(_hotel.Categories[categories.Key].NameCategory);
                        floorNode.Nodes.Add(categoryNode);
                        foreach (var room in categories)
                        {
                            var count = _hotel.RoomUsed(room, dtpArrivalDate.Value, dtpDepartureDate.Value);
                            var status = room.NumberSeat == count ? "(занят)" : count != 0 ? string.Format($"(ещё: {room.NumberSeat - count})") : "";
                            var roomNode = new TreeNode(string.Format($"{room.RoomNumber} {status}")) { Tag = room };
                            _index.Add(room, roomNode);
                            categoryNode.Nodes.Add(roomNode);
                        }
                    }
                }

            }
            finally
            {
                tvRooms.EndUpdate();
                tvRooms.AfterSelect += tvRooms_AfterSelect;
            }
            // раскрываем все узлы этажей
            tvRooms.ExpandAll();
        }

        private void ResetFilters()
        {
            _room = null;
            // заполнение списка клиентов
            cbClientFullName.Items.Clear();
            foreach (var client in _hotel.Clients.OrderedBySurname())
                cbClientFullName.Items.Add(client);
        }

        //занесение данных из объекта данных в контролы
        public void Build(Reservation data)
        {
            Data = data;

            updating++; //включаем режим обновления

            BuildTree();

            // присваиваем текущее значение списка постояльцев
            foreach (var item in cbClientFullName.Items.Cast<Client>())
            {
                if (item.IdClient == data.IdClient)
                {
                    cbClientFullName.SelectedItem = item;
                    break;
                }
            }
            // если комната выбрана
            if (cbClientFullName.SelectedItem != null)
            {
                // день заезда
                dtpArrivalDate.Value = data.ArrivalDate.Date;
                // день выезда
                dtpDepartureDate.Value = data.DepartureDate.Date;
                _room = _hotel.Rooms.Get(data.IdRoom);
                if (_room != null)
                {
                    UpdateRoomNumber(_room);
                    UpdateServicesChecklistbox(_room.Services);
                    UpdateArrivalPrice(_room);
                    var node = _index[_room];
                    node.EnsureVisible();
                    tvRooms.SelectedNode = node;
                    tvRooms.Select();
                }
            }
            else
            {
                // при создании заселения выставляется текущая дата
                dtpArrivalDate.Value = DateTime.Now.Date;
                dtpDepartureDate.Value = DateTime.Now.AddDays(1).Date;
            }

            updating--; //выключаем режим обновления
        }

        /// <summary>
        /// Выставление подключённых услуг
        /// </summary>
        /// <param name="services"></param>
        private void UpdateServicesChecklistbox(Services services)
        {
            lbServices.Items.Clear();
            foreach (var item in services)
                lbServices.Items.Add(item);
        }

        //Занесение данных из контролов в Data
        public void UpdateData()
        {
            if (updating > 0) return; //мы находимся в режиме обновления, не обрабатываем

            // указываем выбранного постояльца
            if (cbClientFullName.SelectedItem != null)
                Data.IdClient = ((Client)cbClientFullName.SelectedItem).IdClient;
            // указываем  выбранную комнату
            Data.IdRoom = _room.IdRoom;
            // заезд и выезд
            Data.ArrivalDate = dtpArrivalDate.Value.Date;
            Data.DepartureDate = dtpDepartureDate.Value.Date;
        }

        private void cbClientFullName_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            UpdateOkButton();
        }

        /// <summary>
        /// Разрешение кнопки ввода
        /// </summary>
        private void UpdateOkButton()
        {
            btnOk.Enabled = cbClientFullName.SelectedItem != null && _room != null &&
                            dtpArrivalDate.Value < dtpDepartureDate.Value;
        }

        /// <summary>
        /// При нажатии кнопки Ок обновляем данные модели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateData();
                DialogResult = DialogResult.OK;//выход из формы, если все введено правильно
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//выводим сообщение об ошибке и не закрываем форму
            }
        }

        /// <summary>
        /// Обработчик изменения даты приезда и отъезда
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpArrivalDate_ValueChanged(object sender, EventArgs e)
        {
            BuildTree();
            UpdateArrivalPrice(_room);
            UpdateOkButton();
        }

        /// <summary>
        /// Обработчик изменения комнаты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvRooms_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null) return;
            _room = e.Node.Tag as Room;
            if (_room == null) return;
            if (Data.IdRoom != _room.IdRoom && 
                _hotel.RoomBusy(_room, dtpArrivalDate.Value, dtpDepartureDate.Value))
            {
                _room = null;
                lbRoom.Text = "-";
                return;
            }
            UpdateRoomNumber(_room);
            // выставление услуг
            UpdateServicesChecklistbox(_room.Services);
            UpdateArrivalPrice(_room);
            UpdateOkButton();
        }

        /// <summary>
        /// Вывод номера комнаты с атрибутами
        /// </summary>
        /// <param name="room"></param>
        private void UpdateRoomNumber(Room room)
        {
            var category = _hotel.Categories[room.IdCategory];
            lbRoom.Text = string.Format($"{room.RoomNumber} ({room.NumberSeat}-х местный \"{category.NameCategory}\", {room.Floor}-й этаж)");
            lbPriceDay.Text = string.Format($"{room.PriceDay} руб./сут.");
        }

        private void UpdateArrivalPrice(Room room)
        {
            if (room == null) return;
            lbArrivalPrice.Text = string.Format($"{_hotel.CalcArrivalPrice(room, dtpArrivalDate.Value, dtpDepartureDate.Value)} руб.");
        }
    }
}
