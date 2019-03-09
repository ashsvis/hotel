using System.Linq;
using System.Windows.Forms;
using Model;

namespace Reception
{
    public partial class RoomsControl : UserControl
    {
        Hotel _hotel;
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

        private void BuildTreeAndFillTable()
        {
            tsbDeleteRoom.Enabled = false;
            tvFloors.Nodes.Clear();
            var hotelNode = new TreeNode("Гостиница");
            tvFloors.Nodes.Add(hotelNode);

            var floorGroups = Rooms.GroupBy(f => f.Floor)
                        .Select(g => new
                        {
                            Name = g.Key,
                            Count = g.Count(),
                            Rooms = g.Select(f => f)
                        });
            foreach (var floor in Rooms.GroupBy(f => f.Floor))
            {
                var floorOneNode = new TreeNode(string.Format($"{floor.Key} этаж"));
                hotelNode.Nodes.Add(floorOneNode);
            }

            tvFloors.ExpandAll();

            dgvRooms.RowCount = Rooms.Count;
        }

        //Занесение данных из контролов в Rooms
        public void UpdateData()
        {
            //здесь занесение значений контролов в поля Data
            //например:
            //Data.Name = tbName.Text;
        }

        private void tsbAddRoom_Click(object sender, System.EventArgs e)
        {
            var frm = new RoomForm(_hotel);
            frm.Build(new Room());
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                //Rooms.Add(_categories[0].IdCategory, 2, 1, 3500);
                BuildTreeAndFillTable();
            }
        }

        private void dgvRooms_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    var category = _hotel.Categories.FirstOrDefault(item => item.IdCategory == Rooms[e.RowIndex].IdCategory);
                    e.Value = category != null ? category.NameCategory : "(нет данных)";
                    break;
                case 1:
                    e.Value = Rooms[e.RowIndex].NumberSeat;
                    break;
                case 2:
                    e.Value = Rooms[e.RowIndex].Floor;
                    break;
                case 3:
                    e.Value = Rooms[e.RowIndex].PriceDay + " руб.";
                    break;
                case 4:
                    e.Value = Rooms[e.RowIndex].Services.Count;
                    break;
            }
        }
    }
}
