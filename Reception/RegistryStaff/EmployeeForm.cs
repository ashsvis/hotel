using Model;
using System;
using System.Windows.Forms;

namespace Reception
{
    public partial class EmployeeForm : Form
    {
        //счетчик режима обновления
        private int updating;
        private readonly Hotel _hotel;

        public Employee Data { get; set; }

        public EmployeeForm(Hotel hotel)
        {
            InitializeComponent();
            _hotel = hotel;
        }

        //занесение данных из объекта данных в контролы
        public void Build(Employee data)
        {
            Data = data;

            updating++; //включаем режим обновления

            tbSurname.Text = data.Surname;
            tbName.Text = data.Name;
            tbLastName.Text = data.LastName;
            tbPhoneNumber.Text = data.PhoneNumber;

            updating--; //выключаем режим обновления
        }

        //Занесение данных из контролов в Data
        public void UpdateData()
        {
            if (updating > 0) return; //мы находимся в режиме обновления, не обрабатываем
            _hotel.CheckEmployeeFullName(Data, tbSurname.Text, tbName.Text, tbLastName.Text);
            Data.Surname = tbSurname.Text;
            Data.Name = tbName.Text;
            Data.LastName = tbLastName.Text;
            _hotel.CheckPhoneNumber(Data, tbPhoneNumber.Text);
            Data.PhoneNumber = tbPhoneNumber.Text;
        }

        private void tbSurname_TextChanged(object sender, System.EventArgs e)
        {            
            btnOk.Enabled = !string.IsNullOrWhiteSpace(tbSurname.Text) &&
                !string.IsNullOrWhiteSpace(tbName.Text) &&
                !string.IsNullOrWhiteSpace(tbLastName.Text) &&
                !string.IsNullOrWhiteSpace(tbPhoneNumber.Text);
        }

        private void btnOk_Click(object sender, System.EventArgs e)
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
