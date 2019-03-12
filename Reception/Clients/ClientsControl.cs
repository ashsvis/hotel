using System;
using System.Windows.Forms;
using Model;

namespace Reception
{
    public partial class ClientsControl : UserControl
    {
        Hotel _hotel;
        Clients _clients;
        ClientOrdered _ordered = ClientOrdered.BySurname;

        public ClientsControl()
        {
            InitializeComponent();
        }

        //Занесение данных из _clients в контролы
        public void Build(Hotel hotel)
        {
            _hotel = hotel;
            _clients = _hotel.Clients;
            FillTable();
        }

        private void FillTable()
        {
            tsbChangeClient.Enabled = tsbDeleteClient.Enabled = false;
            // устанавливаем размер виртуальной таблицы
            dgvClients.RowCount = _clients.Count;
            // просим перерисовать таблицу
            dgvClients.Invalidate();
        }

        private void dgvClients_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            var sorted = _clients.SortedBy(_ordered);
            if (sorted.Count == 0) return;
            // для каждого столбца виртуальной таблицы
            switch (e.ColumnIndex)
            {
                case 0: // фамилия
                    e.Value = sorted[e.RowIndex].Surname;
                    break;
                case 1: // имя
                    e.Value = sorted[e.RowIndex].Name;
                    break;
                case 2: // отчество
                    e.Value = sorted[e.RowIndex].LastName;
                    break;
                case 3: // дата рождения
                    e.Value = sorted[e.RowIndex].Birthday.ToShortDateString();
                    break;
                case 4: // город
                    e.Value = sorted[e.RowIndex].City;
                    break;
                case 5: // номер телефона
                    e.Value = sorted[e.RowIndex].PhoneNumber;
                    break;
                case 6: // данные паспорта
                    e.Value = sorted[e.RowIndex].Passport;
                    break;
                case 7: // количество детей
                    e.Value = sorted[e.RowIndex].NumberChild;
                    break;
            }
        }

        private void dgvClients_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                case 1:
                case 2:
                    _ordered = ClientOrdered.BySurname;
                    break;
                case 3:
                    _ordered = ClientOrdered.ByBirthday;
                    break;
                case 4:
                    _ordered = ClientOrdered.ByCity;
                    break;
                case 5:
                    _ordered = ClientOrdered.ByPhone;
                    break;
                default:
                    _ordered = ClientOrdered.None;
                    break;
            }
            // перерисовать таблицу
            dgvClients.Invalidate();
        }

        private void tsbNewClient_Click(object sender, EventArgs e)
        {
            var frm = new ClientForm(_hotel); // создаем форму
            frm.Build(new Client()); // создаём "пустого" клиента и заполняем контролы формы
            // показываем форму в диалоге
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                var client = frm.Data; // получаем измененные данные клиента
                _clients.Add(client); // добавляем в список клиентов
                FillTable(); // перестраиваем таблицу
            }
        }

        private void tsbChangeClient_Click(object sender, EventArgs e)
        {
            var frm = new ClientForm(_hotel); // создаем форму
            var sorted = _clients.SortedBy(_ordered);
            frm.Build(sorted[dgvClients.SelectedRows[0].Index]); // заполняем контролы формы параметрами выбранного клиента
            // вызываем форму на редактирование
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                // обновляем виртуальную таблицу
                FillTable();
            }
        }

        private void tsbDeleteClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Удалить данные постояльца?", "Удаление данных постояльца",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var sorted = _clients.SortedBy(_ordered);
                var client = sorted[dgvClients.SelectedRows[0].Index];
                try
                {
                    _hotel.CheckClientUsed(client);
                    // удаляем клиента из списка клиентов
                    _clients.Remove(client);
                    // обновляем данные интерфейса
                    FillTable();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message); //выводим сообщение об ошибке и не закрываем форму
                }
            }
        }

        private void dgvClients_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            tsbChangeClient.Enabled = tsbDeleteClient.Enabled = true;
        }
    }
}
