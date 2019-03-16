using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model;

namespace Reception
{
    public partial class LoginForm : Form
    {
        private readonly Hotel _hotel;

        public AllowedOperations AllowedOperations { get; set; }
        public Employee User { get; set; }
        string PasswordHash { get; set; }


        public LoginForm(Hotel hotel)
        {
            InitializeComponent();
            btnOk.Enabled = false;
            _hotel = hotel;
        }

        public void Build(List<Employee> list)
        {
            cbUsers.Items.Clear();
            foreach (var user in list)
            {
                cbUsers.Items.Add(user);
            }
        }

        private void cbUsers_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            btnOk.Enabled = !string.IsNullOrWhiteSpace(tbPassword.Text) &&
                            cbUsers.SelectedItem != null;
            UpdateData();
        }

        private void UpdateData()
        {
            if (cbUsers.SelectedItem != null)
            {
                var employee = (Employee)cbUsers.SelectedItem;
                AllowedOperations = _hotel.GetEmployeeRole(employee.IdEmployeeRole).AllowedOperations;
                User = employee;
                PasswordHash = employee.Password;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Helper.GetHashString(tbPassword.Text) == PasswordHash)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("Пароль не верный!");
        }
    }
}
