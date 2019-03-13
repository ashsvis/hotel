using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reception
{
    public partial class EmployeeRoleForm : Form
    {
        //счетчик режима обновления
        private int updating;
        private readonly Hotel _hotel;

        public EmployeeRole Data { get; set; }

        public EmployeeRoleForm(Hotel hotel)
        {
            InitializeComponent();
            _hotel = hotel;
        }

        //занесение данных из объекта данных в контролы
        public void Build(EmployeeRole data)
        {
            Data = data;

            updating++; //включаем режим обновления

            tbNameRole.Text = data.NameRole;
            nudSalary.Value = data.Salary;
            cbAllowManageEmployees.Checked = data.AllowedOperations.HasFlag(AllowedOperations.ManageEmployees);
            cbAllowManageClients.Checked = data.AllowedOperations.HasFlag(AllowedOperations.ManageClients);

            updating--; //выключаем режим обновления
        }

        //Занесение данных из контролов в Data
        public void UpdateData()
        {
            if (updating > 0) return; //мы находимся в режиме обновления, не обрабатываем
            _hotel.CheckEmployeeRoleName(Data, tbNameRole.Text);
            Data.NameRole = tbNameRole.Text;
            Data.Salary = nudSalary.Value;
            var allowed = AllowedOperations.None;
            if (cbAllowManageEmployees.Checked)
                allowed |= AllowedOperations.ManageEmployees;
            if (cbAllowManageClients.Checked)
                allowed |= AllowedOperations.ManageClients;
            Data.AllowedOperations = allowed;
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

        private void tbNameRole_TextChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = !string.IsNullOrWhiteSpace(tbNameRole.Text) &&
                            nudSalary.Value > 0;
        }

        private void nudSalary_KeyUp(object sender, KeyEventArgs e)
        {
            tbNameRole_TextChanged(null, EventArgs.Empty);
        }
    }
}
