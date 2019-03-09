using Model;
using System.Windows.Forms;
using System.Linq;

namespace Reception
{
    public partial class RoomForm : Form
    {
        //счетчик режима обновления
        private int updating;

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

            updating++; //включаем режим обновления

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
            nudPriceDay.Value = data.PriceDay;
            var n = 0;
            foreach (var item in clbServices.Items.Cast<Service>().ToList())
            {
                if (data.Services.Contains(item))
                    clbServices.SetItemChecked(n, true);
                n++;
            }

            updating--; //выключаем режим обновления
        }

        //Занесение данных из контролов в Data
        public void UpdateData()
        {
            if (updating > 0) return; //мы находимся в режиме обновления, не обрабатываем
            if (cbCategory.SelectedItem != null)
                Data.IdCategory = ((Category)cbCategory.SelectedItem).IdCategory;
            if (cbNumberSeat.SelectedItem != null)
                Data.NumberSeat = ((KindOfSeat)cbNumberSeat.SelectedItem).NumberSeat;
            Data.Floor = (int)nudFoor.Value;
            Data.PriceDay = nudPriceDay.Value;
            // обновляем услуги
            Data.Services.Clear();
            foreach (var item in clbServices.CheckedItems.Cast<Service>())
                Data.Services.Add(item);
        }

        private void cbCategory_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            btnOk.Enabled = cbCategory.SelectedItem != null &&
                            cbNumberSeat.SelectedItem != null &&
                            nudFoor.Value > 0 &&
                            nudPriceDay.Value > 0;
            UpdateData();
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            UpdateData();
        }
    }
}
