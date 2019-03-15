using System;
using System.Windows.Forms;
using Model;
using System.Linq;

namespace Reception
{
    public partial class AccordancePayChannelsControl : UserControl
    {
        Hotel _hotel;
        AccordancePayChannels _accordances;

        public AccordancePayChannelsControl()
        {
            InitializeComponent();
        }

        //Занесение данных из _clients в контролы
        public void Build(Hotel hotel)
        {
            _hotel = hotel;
            _accordances = _hotel.AccordancePayChannels;
            FillTable();
        }

        private void FillTable()
        {
            tsbChangeAccordance.Enabled = tsbDeleteAccordance.Enabled = false;
            // устанавливаем размер виртуальной таблицы
            dgvAccordances.RowCount = _accordances.Count;
            // просим перерисовать таблицу
            dgvAccordances.Invalidate();
        }

        private void dgvAccordances_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            var sorted = _accordances.OrderByClient(_hotel);
            if (sorted.Count == 0) return;
            // для каждого столбца виртуальной таблицы
            Reservation reservation;
            switch (e.ColumnIndex)
            {
                case 0: // Фамилия клиента
                    reservation = _hotel.GetReservation(sorted[e.RowIndex].IdReservation);
                    var client = _hotel.GetClient(reservation.IdClient);
                    e.Value = string.Format($"{client.Surname} {client.Name} {client.LastName}");
                    break;
                case 1:
                    reservation = _hotel.GetReservation(sorted[e.RowIndex].IdReservation);
                    var room = _hotel.GetRoom(reservation.IdRoom);
                    var category = _hotel.Categories[room.IdCategory];
                    e.Value = string.Format($"{category} №{room.RoomNumber}");
                    break;
                case 2:
                    e.Value = sorted[e.RowIndex].PayChannels.Count;
                    break;
            }
        }

        private void tsbNewAccordance_Click(object sender, EventArgs e)
        {
            var frm = new AccordancePayChannelsForm(_hotel); // создаем форму
            frm.Build(new AccordancePayChannel()); // создаём "пустой" подписки и заполняем контролы формы
            // показываем форму в диалоге
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                var accordance = frm.Data; // получаем измененные данные клиента
                _accordances.Add(accordance); // добавляем в список клиентов
                FillTable(); // перестраиваем таблицу
            }
        }

        private void tsbChangeAccordance_Click(object sender, EventArgs e)
        {
            var frm = new AccordancePayChannelsForm(_hotel); // создаем форму
            var sorted = _accordances.OrderByClient(_hotel);
            frm.Build(sorted[dgvAccordances.SelectedRows[0].Index]); // заполняем контролы формы параметрами выбранной подписки
            // вызываем форму на редактирование
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                // обновляем виртуальную таблицу
                FillTable();
            }
        }

        private void tsbDeleteAccordance_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Удалить данные подписки?", "Удаление данных подписки",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var sorted = _accordances.OrderByClient(_hotel);
                var channel = sorted[dgvAccordances.SelectedRows[0].Index];
                try
                {
                    // удаляем подписки из списка подписок
                    _accordances.Remove(channel);
                    // обновляем данные интерфейса
                    FillTable();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message); //выводим сообщение об ошибке и не закрываем форму
                }
            }
        }

        private void dgvAccordances_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            tsbChangeAccordance.Enabled = tsbDeleteAccordance.Enabled = true;
        }
    }
}
