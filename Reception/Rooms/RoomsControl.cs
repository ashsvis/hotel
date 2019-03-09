using System.Linq;
using System.Windows.Forms;
using Model;

namespace Reception
{
    public partial class RoomsControl : UserControl
    {
        Hotel _hotel;
        int _floor;
        RoomOrdered _ordered = RoomOrdered.ByFloor;

        // Свойство, хранящее отображаемый объект модели данных
        public Rooms Rooms { get; private set; }

        public RoomsControl()
        {
            InitializeComponent();
        }

        //Занесение данных из Rooms в контролы
        public void Build(Hotel hotel)
        {
            _hotel = hotel;
            Rooms = _hotel.Rooms;
            BuildTreeAndFillTable();
        }

        /// <summary>
        /// Заполнение "дерева" номеров по этажам
        /// </summary>
        private void BuildTreeAndFillTable()
        {
            _floor = 0; // сбрасываем номер выбранного этажа
            // запрет кнопок на изменение и удаление номера
            tsbChangeRoom.Enabled = tsbDeleteRoom.Enabled = false;
            // обработчик выбора узла отключим на время заполнения дерева
            tvFloors.AfterSelect -= tvFloors_AfterSelect;
            try
            {
                tvFloors.Nodes.Clear();
                // добавим корневой узел
                var hotelNode = new FloorTreeNode("Гостиница");
                tvFloors.Nodes.Add(hotelNode);
                // сформируем группы номеров по этажам
                foreach (var floor in Rooms.OrderBy(f => f.Floor).GroupBy(f => f.Floor))
                {
                    // добавляем узы этажей
                    var floorNode = new FloorTreeNode(string.Format($"{floor.Key} этаж")) { Floor = floor.Key };
                    hotelNode.Nodes.Add(floorNode);
                }
                // раскрываем все узлы этажей
                tvFloors.ExpandAll();
                // устанавливаем размер виртуальной таблицы
                dgvRooms.RowCount = Rooms.Count;
                // просим перерисовать таблицу
                dgvRooms.Invalidate();
            }
            finally
            {
                // подключаем обработчик выбора узла
                tvFloors.AfterSelect += tvFloors_AfterSelect;
            }
        }

        /// <summary>
        /// Нажатие кнопки "Добавить номер"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAddRoom_Click(object sender, System.EventArgs e)
        {
            var frm = new RoomForm(_hotel); // создаем форму
            frm.Build(new Room(_hotel)); // создаём "пустую" комнату и заполняем контролы формы
            // показываем форму в диалоге
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                var room = frm.Data; // получаем измененные данные комнаты
                Rooms.Add(room); // добавляем в список номеров
                BuildTreeAndFillTable(); // перестраиваем дерево этажей
            }
        }

        /// <summary>
        /// Обработчик получения данных из модели для виртуальной таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRooms_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            // получаем список комнат с фильтром по этажу
            var filtered = Rooms.FilteredByFloor(_floor, _ordered);
            // для каждого столбца виртуальной таблицы
            switch (e.ColumnIndex)
            {
                case 0: // категория номера
                    var category = _hotel.Categories[filtered[e.RowIndex].IdCategory];
                    e.Value = category.NameCategory;
                    break;
                case 1: // количество гостей
                    e.Value = filtered[e.RowIndex].NumberSeat;
                    break;
                case 2: // номер этажа
                    e.Value = filtered[e.RowIndex].Floor;
                    break;
                case 3: // стоимость номера за сутки
                    e.Value = filtered[e.RowIndex].PriceDay + " руб.";
                    break;
                case 4: // количество подключенных услуг в номере
                    e.Value = filtered[e.RowIndex].Services.Count;
                    break;
            }
        }

        /// <summary>
        /// При выборе строки в виртуальной таблице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRooms_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // разрешаем кнопки изменения и удаления для комнат
            tsbChangeRoom.Enabled = tsbDeleteRoom.Enabled = true;
        }

        /// <summary>
        /// Нажатие кнопки "Изменить номер"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbChangeRoom_Click(object sender, System.EventArgs e)
        {
            var frm = new RoomForm(_hotel); // создаем форму
            var filtered = Rooms.FilteredByFloor(_floor, _ordered); // получаем отфильтрованный по этажам список комнат
            frm.Build(filtered[dgvRooms.SelectedRows[0].Index]); // заполняем контролы формы параметрами выбранной комнаты
            // вызываем форму на редактирование
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                // обновляем дерево этажей и виртуальную таблицу
                BuildTreeAndFillTable();
            }
        }

        /// <summary>
        /// Нажата кнопка "Удалитьт комнату"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbDeleteRoom_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show(this, "Удалить номер?", "Удаление номера", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var filtered = Rooms.FilteredByFloor(_floor, _ordered); // получаем отфильтрованный по этажам список комнат
                // получаем комнату из этого списка
                var room = filtered[dgvRooms.SelectedRows[0].Index];
                // удаляем комнату из списка комнат
                Rooms.Remove(room);
                // обновляем данные интерфейса
                BuildTreeAndFillTable();
            }
        }

        /// <summary>
        /// При выборе узла в "дереве" этажей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvFloors_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // при выборе пустого места узел не предается, выходим
            if (e.Node == null) return;
            var floorNode = (FloorTreeNode)e.Node;
            // получаем номер этажа и запоминаем для фильтации
            _floor = floorNode.Floor;
            // обновляем количество строк в виртуальной таблице с учетом фильтра
            dgvRooms.RowCount = Rooms.FilteredByFloor(_floor).Count();
            // обновляем интерфейс
            dgvRooms.Invalidate();
        }

        private void dgvRooms_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    _ordered = RoomOrdered.ByCategory;
                    break;
                case 1:
                    _ordered = RoomOrdered.ByNumberSeat;
                    break;
                case 2:
                    _ordered = RoomOrdered.ByFloor;
                    break;
                case 3:
                    _ordered = RoomOrdered.ByPriceDay;
                    break;
                default:
                    _ordered = RoomOrdered.None;
                    break;
            }
            // просим перерисовать таблицу
            dgvRooms.Invalidate();
        }
    }

    /// <summary>
    /// Вспомогательный класс для работы с "деревом" этажей
    /// </summary>
    public class FloorTreeNode : TreeNode
    {
        public int Floor { get; set; } // здесь храним номер этажа

        public FloorTreeNode(string text) : base (text)
        {
            // конструктор для поддержки базового конструктора с одним параметром
        }
    }
}
