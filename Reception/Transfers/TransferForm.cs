using Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Reception
{
    public partial class TransferForm : Form
    {
        //счетчик режима обновления
        private int updating;
        private readonly Hotel _hotel;

        public Transfer Data { get; set; }

        public TransferForm(Hotel hotel)
        {
            InitializeComponent();
            _hotel = hotel;
            // заполнение списка бронирования
            foreach (var reservation in hotel.Reservations)
                cbReservation.Items.Add(reservation);
        }

        //занесение данных из объекта данных в контролы
        public void Build(Transfer data)
        {
            Data = data;

            updating++; //включаем режим обновления
            // присваиваем текущее значение списка бронирования
            foreach (var item in cbReservation.Items.Cast<Reservation>())
            {
                if (item.IdReservation == data.IdReservation)
                {
                    cbReservation.SelectedItem = item;
                    break;
                }
            }
            tbFeedAddress.Text = data.FeedAddress;
            dtpFeedDate.Value = data.FeedDateTime;
            dtpFeedTime.Value = data.FeedDateTime;
            nudNumberSeat.Value = data.NumberSeat;
            if (cbReservation.SelectedItem == null)
            {
                var now = DateTime.Now;
                dtpFeedDate.Value = now;
                dtpFeedTime.Value = now;
            }

            updating--; //выключаем режим обновления
        }

        //Занесение данных из контролов в Data
        public void UpdateData()
        {
            if (updating > 0) return; //мы находимся в режиме обновления, не обрабатываем
            // указываем выбранную бронь
            if (cbReservation.SelectedItem != null)
                Data.IdReservation = ((Reservation)cbReservation.SelectedItem).IdReservation;
            Data.FeedAddress = tbFeedAddress.Text;
            Data.FeedDateTime = dtpFeedDate.Value.Date + dtpFeedTime.Value.TimeOfDay;
            Data.NumberSeat = (int)nudNumberSeat.Value;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateData();
                DialogResult = DialogResult.OK; //выход из формы, если все введено правильно
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //выводим сообщение об ошибке и не закрываем форму
            }
        }

        private void tbFeedAddress_TextChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = !string.IsNullOrWhiteSpace(tbFeedAddress.Text) &&
                            nudNumberSeat.Value > 0;
        }

        private void nudNumberSeat_KeyUp(object sender, KeyEventArgs e)
        {
            tbFeedAddress_TextChanged(null, EventArgs.Empty);
        }
    }
}
