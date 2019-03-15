using Model;
using System;
using System.Linq;
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
            // заполнение списка должностей
            foreach (var role in hotel.EmployeeRoles.OrderBy(item => item.NameRole))
                cbEmployeeRole.Items.Add(role);
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
            // присваиваем текущее значение списка должностей
            foreach (var item in cbEmployeeRole.Items.Cast<EmployeeRole>())
            {
                if (item.IdEmployeeRole == data.IdEmployeeRole)
                {
                    cbEmployeeRole.SelectedItem = item;
                    break;
                }
            }

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
            _hotel.CheckEmployeePhoneNumber(Data, tbPhoneNumber.Text);
            Data.PhoneNumber = tbPhoneNumber.Text;
            // указываем выбранную должность
            if (cbEmployeeRole.SelectedItem != null)
                Data.IdEmployeeRole = ((EmployeeRole)cbEmployeeRole.SelectedItem).IdEmployeeRole;
            if (!string.IsNullOrWhiteSpace(tbPassword.Text))
                Data.Password = Helper.GetHashString(tbPassword.Text);
        }

        private void tbSurname_TextChanged(object sender, System.EventArgs e)
        {            
            btnOk.Enabled = !string.IsNullOrWhiteSpace(tbSurname.Text) &&
                !string.IsNullOrWhiteSpace(tbName.Text) &&
                !string.IsNullOrWhiteSpace(tbLastName.Text) &&
                !string.IsNullOrWhiteSpace(tbPhoneNumber.Text) &&
                cbEmployeeRole.SelectedItem != null;
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
