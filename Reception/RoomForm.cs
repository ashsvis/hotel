using Model;
using System.Windows.Forms;
using System.Linq;

namespace Reception
{
    public partial class RoomForm : Form
    {
        public Room Data { get; set; }

        public RoomForm(Categories categories, Services services)
        {
            InitializeComponent();
            foreach (var category in categories)
                cbCategory.Items.Add(category);

            cbNumberSeat.Items.Add(new KindOfSeat { Descriptor = "Двухместный", NumberSeat = 2 });
            cbNumberSeat.Items.Add(new KindOfSeat { Descriptor = "Одноместный", NumberSeat = 1 });
            cbNumberSeat.Items.Add(new KindOfSeat { Descriptor = "Трёхместный", NumberSeat = 2 });

            foreach (var service in services)
            {
                clbServices.Items.Add(service);
            }
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

    public class KindOfSeat
    {
        public int NumberSeat { get; set; }
        public string Descriptor { get; set; }

        public override string ToString()
        {
            return Descriptor;
        }
    }
}
