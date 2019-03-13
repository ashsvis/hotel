using Model;
using System;
using System.Windows.Forms;

namespace Reception
{
    public partial class ClientForm : Form
    {
        //счетчик режима обновления
        private int updating;
        private readonly Hotel _hotel;

        public Client Data { get; set; }

        public ClientForm(Hotel hotel)
        {
            InitializeComponent();
            _hotel = hotel;
        }

        //занесение данных из объекта данных в контролы
        public void Build(Client data)
        {
            Data = data;

            updating++; //включаем режим обновления

            if (string.IsNullOrWhiteSpace(data.Surname))
            {
                var namesGenerator = new NamesGenerator();
                var name = namesGenerator.GetFullName();
                tbSurname.Text = name.Item1;
                tbName.Text = name.Item2;
                tbLastName.Text = name.Item3;
                var phoneGenerator = new PhoneNumberGenerator();
                tbPhoneNumber.Text = phoneGenerator.GetNumber();
                var dateGenerator = new BirthdayGenerator();
                dtpBirthday.Value = dateGenerator.GetDate();
                tbCity.Text = "Москва";
                var pasportGenerator = new PassportNumberGenerator();
                tbPassport.Text = pasportGenerator.GetNumber();
                nudNumberChild.Value = 0;
            }
            else
            {
                tbSurname.Text = data.Surname;
                tbName.Text = data.Name;
                tbLastName.Text = data.LastName;
                tbPhoneNumber.Text = data.PhoneNumber;
                dtpBirthday.Value = data.Birthday;
                tbCity.Text = data.City;
                tbPassport.Text = data.Passport;
                nudNumberChild.Value = data.NumberChild;
            }

            updating--; //выключаем режим обновления
        }

        //Занесение данных из контролов в Data
        public void UpdateData()
        {
            if (updating > 0) return; //мы находимся в режиме обновления, не обрабатываем
            _hotel.CheckClientFullName(Data, tbSurname.Text, tbName.Text, tbLastName.Text);
            Data.Surname = tbSurname.Text;
            Data.Name = tbName.Text;
            Data.LastName = tbLastName.Text;
            _hotel.CheckClientPhoneNumber(Data, tbPhoneNumber.Text);
            Data.PhoneNumber = tbPhoneNumber.Text;
            Data.Birthday = dtpBirthday.Value;
            Data.City = tbCity.Text;
            _hotel.CheckClientPassport(Data, tbPassport.Text);
            Data.Passport = tbPassport.Text;
            Data.NumberChild = (int)nudNumberChild.Value;
        }

        private void tbSurname_TextChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = !string.IsNullOrWhiteSpace(tbSurname.Text) &&
                !string.IsNullOrWhiteSpace(tbName.Text) &&
                !string.IsNullOrWhiteSpace(tbLastName.Text) &&
                !string.IsNullOrWhiteSpace(tbPhoneNumber.Text);
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
    }
}
