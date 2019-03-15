using Model;
using System;
using System.Windows.Forms;
using System.Linq;

namespace Reception
{
    public partial class RoomForm : Form
    {
        //счетчик режима обновления
        private int updating;
        private readonly Hotel _hotel;

        public Room Data { get; set; }

        public RoomForm(Hotel hotel)
        {
            InitializeComponent();
            _hotel = hotel;
            // заполнение списка категорий
            foreach (var category in hotel.Categories.OrderBy(item => item.Value.NameCategory))
                cbCategory.Items.Add(category.Value);
            // заполнение списка мест для номеров
            for (var seat = 1; seat < 4; seat++)
                cbNumberSeat.Items.Add(seat);
            // заполнение возможных услуг в номере
            foreach (var service in hotel.Services.OrderBy(item => item.NameService))
                clbServices.Items.Add(service);
        }

        //занесение данных из объекта данных в контролы
        public void Build(Room data)
        {
            Data = data;

            updating++; //включаем режим обновления

            tbRoomNumber.Text = data.RoomNumber;
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
            foreach (var seat in cbNumberSeat.Items.Cast<int>())
            {
                if (seat == data.NumberSeat)
                {
                    cbNumberSeat.SelectedItem = seat;
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
            _hotel.CheckRoomNumber(Data, tbRoomNumber.Text);
            Data.RoomNumber = tbRoomNumber.Text;
            // указываем выбранную категорию
            if (cbCategory.SelectedItem != null)
                Data.IdCategory = ((Category)cbCategory.SelectedItem).IdCategory;
            // указываем количество мест в номере
            if (cbNumberSeat.SelectedItem != null)
                Data.NumberSeat = (int)cbNumberSeat.SelectedItem;
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
            btnOk.Enabled = !string.IsNullOrWhiteSpace(tbRoomNumber.Text) &&
                            cbCategory.SelectedItem != null &&
                            cbNumberSeat.SelectedItem != null &&
                            nudFoor.Value > 0 &&
                            nudPriceDay.Value > 0;
            UpdateData();
            lbTotal.Text = string.Format($"{Data.CalcPriceDayTotal()} руб.");
        }

        /// <summary>
        /// При нажатии кнопки Ок обновляем данные модели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, System.EventArgs e)
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

        private void nudPriceDay_KeyUp(object sender, KeyEventArgs e)
        {
            cbCategory_SelectionChangeCommitted(null, EventArgs.Empty);
        }
    }
}
