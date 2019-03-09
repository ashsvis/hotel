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
            // заполнение списка категорий
            foreach (var category in hotel.Categories)
                cbCategory.Items.Add(category);
            // заполнение списка мест для номеров
            foreach (var seat in hotel.Seats)
                cbNumberSeat.Items.Add(seat);
            // заполнение возможных услуг в номере
            foreach (var service in hotel.Services)
                clbServices.Items.Add(service);
        }

        //занесение данных из объекта данных в контролы
        public void Build(Room data)
        {
            Data = data;

            updating++; //включаем режим обновления
            // присваиваем текущее значение списка категорий
            foreach (var item in cbCategory.Items.Cast<Category>())
            {
                if (item.IdCategory == data.IdCategory)
                {
                    cbCategory.SelectedItem = item;
                    break;
                }
            }
            // присваиваем текущее значение списка мест
            foreach (var item in cbNumberSeat.Items.Cast<KindOfSeat>())
            {
                if (item.NumberSeat == data.NumberSeat)
                {
                    cbNumberSeat.SelectedItem = item;
                    break;
                }
            }
            nudFoor.Value = data.Floor; // этаж
            nudPriceDay.Value = data.PriceDay; // цена номера за день
            // выставление галочек подключённых услуг
            var n = 0;
            foreach (var item in clbServices.Items.Cast<Service>().ToList())
            {
                // если услуга подключена, устанавливаем для неё "галочку"
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
            // указываем выбранную категорию
            if (cbCategory.SelectedItem != null)
                Data.IdCategory = ((Category)cbCategory.SelectedItem).IdCategory;
            // указываем количество мест в номере
            if (cbNumberSeat.SelectedItem != null)
                Data.NumberSeat = ((KindOfSeat)cbNumberSeat.SelectedItem).NumberSeat;
            // указываем этаж
            Data.Floor = (int)nudFoor.Value;
            // указываем цену номера за сутки
            Data.PriceDay = nudPriceDay.Value;
            // обновляем услуги подключаемые услуги в номере
            Data.Services.Clear();
            foreach (var item in clbServices.CheckedItems.Cast<Service>())
                Data.Services.Add(item);
        }

        /// <summary>
        /// Изменение данных контролов фиксируются в этом методе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbCategory_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            btnOk.Enabled = cbCategory.SelectedItem != null &&
                            cbNumberSeat.SelectedItem != null &&
                            nudFoor.Value > 0 &&
                            nudPriceDay.Value > 0;
        }

        /// <summary>
        /// При нажатии кнопки Ок обновляем данные модели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, System.EventArgs e)
        {
            UpdateData();
        }
    }
}
