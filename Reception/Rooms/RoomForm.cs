using Model;
using System.Windows.Forms;
using System.Linq;

namespace Reception
{
    public partial class RoomForm : Form
    {
        public Room Data { get; set; }

        public RoomForm(Hotel hotel)
        {
            InitializeComponent();
            foreach (var category in hotel.Categories)
                cbCategory.Items.Add(category);
            foreach (var seat in hotel.Seats)
                cbNumberSeat.Items.Add(seat);
            foreach (var service in hotel.Services)
                clbServices.Items.Add(service);
        }

        //занесение данных из объекта данных в контролы
        public void Build(Room data)
        {
            Data = data;
            foreach (var item in cbCategory.Items.Cast<Category>())
            {
                if (item.IdCategory == data.IdCategory)
                {
                    cbCategory.SelectedItem = item;
                    break;
                }
            }
            foreach (var item in cbNumberSeat.Items.Cast<KindOfSeat>())
            {
                if (item.NumberSeat == data.NumberSeat)
                {
                    cbNumberSeat.SelectedItem = item;
                    break;
                }
            }
            nudFoor.Value = data.Floor;
        }

        private void cbCategory_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            btnOk.Enabled = true;
        }
    }
}
