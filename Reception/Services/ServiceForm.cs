using Model;
using System;
using System.Windows.Forms;

namespace Reception
{
    public partial class ServiceForm : Form
    {
        //счетчик режима обновления
        private int updating;
        private readonly Hotel _hotel;

        public Service Data { get; set; }

        public ServiceForm(Hotel hotel)
        {
            InitializeComponent();
            _hotel = hotel;
        }

        //занесение данных из объекта данных в контролы
        public void Build(Service data)
        {
            Data = data;

            updating++; //включаем режим обновления

            tbNameService.Text = data.NameService;
            nudPriceDay.Value = data.PriceDay;

            updating--; //выключаем режим обновления
        }

        //Занесение данных из контролов в Data
        public void UpdateData()
        {
            if (updating > 0) return; //мы находимся в режиме обновления, не обрабатываем
            _hotel.CheckServiceName(Data, tbNameService.Text);
            Data.NameService = tbNameService.Text;
            Data.PriceDay = nudPriceDay.Value;
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

        private void tbNameService_TextChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = !string.IsNullOrWhiteSpace(tbNameService.Text) &&
                            nudPriceDay.Value > 0;
        }

        private void nudPriceDay_KeyUp(object sender, KeyEventArgs e)
        {
            tbNameService_TextChanged(null, EventArgs.Empty);
        }
    }
}
