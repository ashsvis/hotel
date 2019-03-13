using Model;
using System;
using System.Windows.Forms;

namespace Reception
{
    public partial class PayChannelForm : Form
    {
        //счетчик режима обновления
        private int updating;
        private readonly Hotel _hotel;

        public PayChannel Data { get; set; }


        public PayChannelForm(Hotel hotel)
        {
            InitializeComponent();
            _hotel = hotel;
        }

        //занесение данных из объекта данных в контролы
        public void Build(PayChannel data)
        {
            Data = data;

            updating++; //включаем режим обновления

            tbNameChannel.Text = data.NameChannel;
            nudPriceHour.Value = data.PriceHour;

            updating--; //выключаем режим обновления
        }

        //Занесение данных из контролов в Data
        public void UpdateData()
        {
            if (updating > 0) return; //мы находимся в режиме обновления, не обрабатываем
            _hotel.CheckPayChannelName(Data, tbNameChannel.Text);
            Data.NameChannel = tbNameChannel.Text;
            Data.PriceHour = nudPriceHour.Value;
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

        private void tbNameChannel_TextChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = !string.IsNullOrWhiteSpace(tbNameChannel.Text) &&
                            nudPriceHour.Value > 0;
        }

        private void nudPriceHour_KeyUp(object sender, KeyEventArgs e)
        {
            tbNameChannel_TextChanged(null, EventArgs.Empty);
        }
    }
}
