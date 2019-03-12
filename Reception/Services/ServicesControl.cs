using System.Windows.Forms;
using Model;
using System.Linq;
using System;

namespace Reception
{
    public partial class ServicesControl : UserControl
    {
        Hotel _hotel;
        Services _services;

        public ServicesControl()
        {
            InitializeComponent();
        }

        //Занесение данных из _services в контролы
        public void Build(Hotel hotel)
        {
            _hotel = hotel;
            _services = _hotel.Services;
            FillTable();
        }

        private void FillTable()
        {
            tsbChangeService.Enabled = tsbDeleteService.Enabled = false;
            // устанавливаем размер виртуальной таблицы
            dgvServices.RowCount = _services.Count;
            // просим перерисовать таблицу
            dgvServices.Invalidate();
        }

        private void dgvServices_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            var sorted = _services.OrderBy(item => item.NameService).ToList();
            if (sorted.Count == 0) return;
            // для каждого столбца виртуальной таблицы
            switch (e.ColumnIndex)
            {
                case 0: // наименование услуги
                    e.Value = sorted[e.RowIndex].NameService;
                    break;
                case 1: // стоимость услуги за сутки
                    e.Value = sorted[e.RowIndex].PriceDay + " руб.";
                    break;
            }
        }

        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbChangeService.Enabled = tsbDeleteService.Enabled = true;
        }

        private void tsbNewService_Click(object sender, System.EventArgs e)
        {
            var frm = new ServiceForm(_hotel); // создаем форму
            frm.Build(new Service()); // создаём "пустую" услугу и заполняем контролы формы
            // показываем форму в диалоге
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                var service = frm.Data;
                _services.Add(service); // добавляем в список услуг
                FillTable(); // перестраиваем таблицу
            }
        }

        private void tsbChangeService_Click(object sender, System.EventArgs e)
        {
            var frm = new ServiceForm(_hotel); // создаем форму
            var sorted = _services.OrderBy(item => item.NameService).ToList();
            frm.Build(sorted[dgvServices.SelectedRows[0].Index]); // заполняем контролы формы параметрами выбранной услуги
            // вызываем форму на редактирование
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                // обновляем виртуальную таблицу
                FillTable();
            }
        }

        private void tsbDeleteService_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show(this, "Удалить данные услуги?", "Удаление услуги",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var sorted = _services.OrderBy(item => item.NameService).ToList();
                var service = sorted[dgvServices.SelectedRows[0].Index];
                try
                {
                    _hotel.CheckServiceUsed(service);
                    _services.Remove(service);
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
