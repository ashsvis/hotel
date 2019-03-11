using System;
using System.Linq;
using System.Windows.Forms;
using Model;

namespace Reception
{
    public partial class ArrivalsControl : UserControl
    {
        Hotel _hotel;
        Arrivals _arrivals;

        public ArrivalsControl()
        {
            InitializeComponent();
        }

        //Занесение данных из _arrivals в контролы
        public void Build(Hotel hotel)
        {
            _hotel = hotel;
            _arrivals = _hotel.Arrivals;
            FillTable();
        }

        private void FillTable()
        {
            tsbChangeArrivalClient.Enabled = tsbDepartureClient.Enabled = false;
            // устанавливаем размер виртуальной таблицы
            dgvArrivals.RowCount = _arrivals.Count;
            // просим перерисовать таблицу
            dgvArrivals.Invalidate();
        }

        private void dgvArrivals_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            var sorted = _arrivals;
            if (sorted.Count == 0) return;
            // для каждого столбца виртуальной таблицы
            switch (e.ColumnIndex)
            {
                case 0: // фамилия, имя и отчество клиента
                    var clientId = sorted[e.RowIndex].IdClient;
                    var client = _hotel.Clients.FirstOrDefault(item => item.IdClient == clientId);
                    e.Value = client != null 
                        ? string.Format($"{client.Surname} {client.Name} {client.LastName}") 
                        : "нет данных";
                    break;
                case 1: // информация о номере
                    var roomId = sorted[e.RowIndex].IdRoom;
                    var room = _hotel.Rooms.FirstOrDefault(item => item.IdRoom == roomId);
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
            }
        }

        /// <summary>
        /// Нажатие кнопки "Заселение"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbArrivalClient_Click(object sender, EventArgs e)
        {
            var frm = new ArrivalForm(_hotel); // создаем форму
            frm.Build(new Arrival()); // создаём "пустое" заселение и заполняем контролы формы
            // показываем форму в диалоге
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                var arrival = frm.Data; // получаем измененные данные клиента
                _arrivals.Add(arrival); // добавляем в список клиентов
                FillTable(); // перестраиваем таблицу
            }
        }

        /// <summary>
        /// Нажатие кнопки "Изменить данные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbChangeArrivalClient_Click(object sender, EventArgs e)
        {
            var frm = new ArrivalForm(_hotel); // создаем форму
            frm.Build(_arrivals[dgvArrivals.SelectedRows[0].Index]); // заполняем контролы формы параметрами выбранного заезда
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
            if (MessageBox.Show(this, "Удалить информацию о заселении?", "Удаление заезда",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var arival = _arrivals[dgvArrivals.SelectedRows[0].Index];
                // удаляем комнату из списка комнат
                _arrivals.Remove(arival);
                // обновляем данные интерфейса
                FillTable();
            }
        }

        private void dgvArrivals_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            tsbChangeArrivalClient.Enabled = tsbDepartureClient.Enabled = true;
        }
    }
}
