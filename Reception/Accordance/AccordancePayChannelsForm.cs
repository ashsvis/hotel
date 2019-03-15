using Model;
using System.Windows.Forms;
using System;
using System.Linq;

namespace Reception
{
    public partial class AccordancePayChannelsForm : Form
    {
        //счетчик режима обновления
        private int updating;
        private readonly Hotel _hotel;

        public AccordancePayChannel Data { get; set; }

        public AccordancePayChannelsForm(Hotel hotel)
        {
            InitializeComponent();
            _hotel = hotel;
            // заполнение списка бронирования
            foreach (var reservation in hotel.Reservations)
                cbReservation.Items.Add(reservation);
            // заполнение возможных каналов для подписки
            foreach (var channel in hotel.PayChannels.OrderBy(item => item.NameChannel))
                clbChannels.Items.Add(channel);
        }

        //занесение данных из объекта данных в контролы
        public void Build(AccordancePayChannel data)
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
            // выставление галочек подключённых каналов
            var n = 0;
            foreach (var item in clbChannels.Items.Cast<PayChannel>().ToList())
            {
                // если канал подключён, устанавливаем для него "галочку"
                if (data.PayChannels.Contains(item))
                    clbChannels.SetItemChecked(n, true);
                n++;
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
            // обновляем подключаемые каналы в номере
            Data.PayChannels.Clear();
            foreach (var item in clbChannels.CheckedItems.Cast<PayChannel>())
                Data.PayChannels.Add(item);
        }

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

        private void cbReservation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnOk.Enabled = cbReservation.SelectedItem != null;
        }
    }
}
