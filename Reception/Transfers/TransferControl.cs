using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Model;

namespace Reception
{
    public partial class TransferControl : UserControl
    {
        Hotel _hotel;
        Transfers _transfers;

        public TransferControl()
        {
            InitializeComponent();
        }

        //Занесение данных из _transfers в контролы
        public void Build(Hotel hotel)
        {
            _hotel = hotel;
            _transfers = _hotel.Transfers;
            FillTable();
        }

        private void FillTable()
        {
            tsbChangeTransfer.Enabled = tsbDeleteTransfer.Enabled = false;
            // устанавливаем размер виртуальной таблицы
            dgvTransfers.RowCount = _transfers.Count;
            // просим перерисовать таблицу
            dgvTransfers.Invalidate();
        }

        private void dgvTransfers_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            var sorted = _transfers.OrderBy(item => item.FeedDateTime).ToList();
            if (sorted.Count == 0) return;
            // для каждого столбца виртуальной таблицы
            Reservation reservation;
            Client client;
            switch (e.ColumnIndex)
            {
                case 0: // дата и время подачи
                    e.Value = sorted[e.RowIndex].FeedDateTime;
                    break;
                case 1: // адрес подачи
                    e.Value = sorted[e.RowIndex].FeedAddress;
                    break;
                case 2: // количество мест
                    e.Value = sorted[e.RowIndex].NumberSeat;
                    break;
                case 3: // Фамилия клиента
                    reservation = _hotel.GetReservation(sorted[e.RowIndex].IdReservation);
                    client = _hotel.GetClient(reservation.IdClient);
                    e.Value = string.Format($"{client.Surname} {client.Name} {client.LastName}");
                    break;
                case 4: // Телефон клиента для связи
                    reservation = _hotel.GetReservation(sorted[e.RowIndex].IdReservation);
                    client = _hotel.GetClient(reservation.IdClient);
                    e.Value = string.Format($"{client.PhoneNumber}");
                    break;
            }
        }

        private void dgvTransfers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbChangeTransfer.Enabled = tsbDeleteTransfer.Enabled = true;
        }

        private void tsbNewTransfer_Click(object sender, System.EventArgs e)
        {
            var frm = new TransferForm(_hotel); // создаем форму
            frm.Build(new Transfer(_hotel)); // создаём "пустую" услугу и заполняем контролы формы
            // показываем форму в диалоге
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                var transfer = frm.Data;
                _transfers.Add(transfer); // добавляем в список услуг
                FillTable(); // перестраиваем таблицу
            }
        }

        private void tsbChangeTransfer_Click(object sender, System.EventArgs e)
        {
            var frm = new TransferForm(_hotel); // создаем форму
            var sorted = _transfers.OrderBy(item => item.FeedDateTime).ToList();
            frm.Build(sorted[dgvTransfers.SelectedRows[0].Index]); // заполняем контролы формы параметрами выбранной услуги
            // вызываем форму на редактирование
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                // обновляем виртуальную таблицу
                FillTable();
            }
        }

        private void tsbDeleteTransfer_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show(this, "Удалить данные заказа доставки?", "Удаление трансфера",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var sorted = _transfers.OrderBy(item => item.FeedDateTime).ToList();
                var service = sorted[dgvTransfers.SelectedRows[0].Index];
                try
                {
                    _transfers.Remove(service);
                    // обновляем данные интерфейса
                    FillTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); //выводим сообщение об ошибке и не закрываем форму
                }
            }
        }
    }
}
