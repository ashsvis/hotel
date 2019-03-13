using System;
using System.Windows.Forms;
using Model;

namespace Reception
{
    public partial class ReservationsControl : UserControl
    {
        Hotel _hotel;
        Reservations _reservations;

        public ReservationsControl()
        {
            InitializeComponent();
        }

        //Занесение данных из _arrivals в контролы
        public void Build(Hotel hotel)
        {
            _hotel = hotel;
            _reservations = _hotel.Reservations;
            FillTable();
        }

        private void FillTable()
        {
            tsbChangeReservationClient.Enabled = tsbDepartureClient.Enabled = false;
            // устанавливаем размер виртуальной таблицы
            dgvReservations.RowCount = _reservations.Count;
            // просим перерисовать таблицу
            dgvReservations.Invalidate();
        }

        private void dgvReservations_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            var sorted = _reservations;
            if (sorted.Count == 0) return;
            // для каждого столбца виртуальной таблицы
            switch (e.ColumnIndex)
            {
                case 0: // фамилия, имя и отчество клиента
                    var clientId = sorted[e.RowIndex].IdClient;
                    var client = _hotel.GetClient(clientId);
                    e.Value = client != null 
                        ? string.Format($"{client.Surname} {client.Name} {client.LastName}") 
                        : "нет данных";
                    break;
                case 1: // информация о номере
                    var roomId = sorted[e.RowIndex].IdRoom;
                    var room = _hotel.GetRoom(roomId);
                    var category = _hotel.Categories[room.IdCategory];
                    e.Value = room != null 
                        ? string.Format($"{room.NumberSeat}-х местный \"{category.NameCategory}\" №{room.RoomNumber} на {room.Floor}-м этаже") 
                        : "нет данных";
                    break;
                case 2: // дата заезда
                    e.Value = sorted[e.RowIndex].ArrivalDate.ToShortDateString();
                    break;
                case 3: // дата выезда
                    e.Value = sorted[e.RowIndex].DepartureDate.ToShortDateString();
                    break;
                case 4: // фамилия, имя и отчество сотрудника
                    var employeeId = sorted[e.RowIndex].IdEmployee;
                    var employee = _hotel.GetEmployee(employeeId);
                    e.Value = employee != null
                        ? string.Format($"{employee.Surname} {employee.Name} {employee.LastName}")
                        : "нет данных";
                    break;
            }
        }

        /// <summary>
        /// Нажатие кнопки "Заселение"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbReservationClient_Click(object sender, EventArgs e)
        {
            var frm = new ArrivalForm(_hotel); // создаем форму
            frm.Build(new Reservation(_hotel)); // создаём "пустое" заселение и заполняем контролы формы
            // показываем форму в диалоге
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                var arrival = frm.Data; // получаем измененные данные клиента
                _reservations.Add(arrival); // добавляем в список клиентов
                FillTable(); // перестраиваем таблицу
            }
        }

        /// <summary>
        /// Нажатие кнопки "Изменить данные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbChangeReservationClient_Click(object sender, EventArgs e)
        {
            var frm = new ArrivalForm(_hotel); // создаем форму
            frm.Build(_reservations[dgvReservations.SelectedRows[0].Index]); // заполняем контролы формы параметрами выбранного заезда
            // вызываем форму на редактирование
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                // обновляем дерево этажей и виртуальную таблицу
                FillTable(); // перестраиваем таблицу
            }
        }

        /// <summary>
        /// Нажатие кнопки "Удалить данные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbDepartureClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Удалить информацию о заселении?", "Удаление брони",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var reservation = _reservations[dgvReservations.SelectedRows[0].Index];
                // удаляем комнату из списка комнат
                _reservations.Remove(reservation);
                // обновляем данные интерфейса
                FillTable();
            }
        }

        private void dgvReservations_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            tsbChangeReservationClient.Enabled = tsbDepartureClient.Enabled = true;
        }
    }
}
