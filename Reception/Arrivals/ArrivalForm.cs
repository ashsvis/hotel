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

        public Arrival Data { get; set; }

        public ArrivalForm(Hotel hotel)
        {
            InitializeComponent();
            _hotel = hotel;
            ResetFilters();
        }

        private void BuildTree()
        {
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
                        var roomNode = new TreeNode(string.Format($"{room.RoomNumber} {status}"))
                                           { Tag = room, Name = room.RoomNumber };
                        categoryNode.Nodes.Add(roomNode);
                    }
                }
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
            // заполнение возможных услуг в номере
            clbServices.Items.Clear();
            foreach (var service in _hotel.Services)
                clbServices.Items.Add(service);
        }

        //занесение данных из объекта данных в контролы
        public void Build(Arrival data)
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
                _room = _hotel.Rooms.Get(data.IdRoom);
                if (_room != null)
                {
                    UpdateRoomNumber(_room);
                    var node = FindRoomInTree(tvRooms.Nodes, _room);
                    if (node != null)
                    {
                        tvRooms.SelectedNode = node;
                        tvRooms.SelectedNode.EnsureVisible();
                    }
                }
                // день заезда
                dtpArrivalDate.Value = data.ArrivalDate.Date;
                // день выезда
                dtpDepartureDate.Value = data.DepartureDate.Date;
            }
            else
            {
                // при создании заселения выставляется текущая дата
                dtpArrivalDate.Value = DateTime.Now.Date;
                dtpDepartureDate.Value = DateTime.Now.AddDays(1).Date;
            }
            // выставление услуг
            UpdateServicesChecklistbox(data.Services);

            updating--; //выключаем режим обновления
        }

        private TreeNode FindRoomInTree(TreeNodeCollection nodes, Room room)
        {
            foreach (var node in nodes.Cast<TreeNode>())
            {
                var r = node.Tag as Room;
                if (r == null) continue;
                if (r.IdRoom == room.IdRoom)
                    return node;
            }
            return FindRoomInTree(node.Nodes, room);
        }

        private void UpdateServicesChecklistbox(Services services)
        {
            // выставление галочек подключённых услуг
            var n = 0;
            foreach (var item in clbServices.Items.Cast<Service>().ToList())
            {
                // если услуга подключена, устанавливаем для неё "галочку"
                if (services.Contains(item))
                    clbServices.SetItemChecked(n, true);
                else
                    clbServices.SetItemChecked(n, false);
                n++;
            }
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
            // обновляем услуги подключаемые услуги в номере
            Data.Services.Clear();
            foreach (var item in clbServices.CheckedItems.Cast<Service>())
                Data.Services.Add(item);
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

        private void dtpArrivalDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateOkButton();
        }

        private void tvRooms_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null) return;
            _room = e.Node.Tag as Room;
            if (_room == null) return;
            UpdateRoomNumber(_room);
            // выставление услуг
            UpdateServicesChecklistbox(_room.Services);
            UpdateOkButton();
        }

        private void UpdateRoomNumber(Room room)
        {
            var category = _hotel.Categories[room.IdCategory];
            lbRoom.Text = string.Format($"{room.RoomNumber} ({room.NumberSeat}-х местный \"{category.NameCategory}\", {room.Floor}-й этаж)");
        }
    }
}
