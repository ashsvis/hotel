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
                    e.Value = client != null ? string.Format($"{client.Surname} {client.Name} {client.LastName}") : "нет данных";
                    break;
            }
        }

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
    }
}
