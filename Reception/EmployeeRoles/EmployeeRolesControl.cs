using System.Data;
using System.Linq;
using System.Windows.Forms;
using Model;
using System;

namespace Reception
{
    public partial class EmployeeRolesControl : UserControl
    {
        Hotel _hotel;
        EmployeeRoles _roles;

        public EmployeeRolesControl()
        {
            InitializeComponent();
        }

        //Занесение данных из _roles в контролы
        public void Build(Hotel hotel)
        {
            _hotel = hotel;
            _roles = _hotel.EmployeeRoles;
            FillTable();
        }

        private void FillTable()
        {
            tsbChangeEmployeeRole.Enabled = tsbDeleteEmployeeRole.Enabled = false;
            // устанавливаем размер виртуальной таблицы
            dgvEmployeeRoles.RowCount = _roles.Count;
            // просим перерисовать таблицу
            dgvEmployeeRoles.Invalidate();
        }

        private void dgvEmployeeRoles_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            var sorted = _roles.OrderBy(item => item.NameRole).ToList();
            if (sorted.Count == 0) return;
            // для каждого столбца виртуальной таблицы
            switch (e.ColumnIndex)
            {
                case 0: // наименование должности
                    e.Value = sorted[e.RowIndex].NameRole;
                    break;
                case 1: // оклад жалования за месяц
                    e.Value = sorted[e.RowIndex].Salary + " руб.";
                    break;
            }
        }

        private void dgvEmployeeRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbChangeEmployeeRole.Enabled = tsbDeleteEmployeeRole.Enabled = true;
        }

        private void tsbNewEmployeeRole_Click(object sender, System.EventArgs e)
        {
            var frm = new EmployeeRoleForm(_hotel); // создаем форму
            frm.Build(new EmployeeRole()); // создаём "пустую" должность и заполняем контролы формы
            // показываем форму в диалоге
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                var role = frm.Data;
                _roles.Add(role); // добавляем в список услуг
                FillTable(); // перестраиваем таблицу
            }
        }

        private void tsbChangeEmployeeRole_Click(object sender, System.EventArgs e)
        {
            var frm = new EmployeeRoleForm(_hotel); // создаем форму
            var sorted = _roles.OrderBy(item => item.NameRole).ToList();
            frm.Build(sorted[dgvEmployeeRoles.SelectedRows[0].Index]); // заполняем контролы формы параметрами выбранной услуги
            // вызываем форму на редактирование
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                // обновляем виртуальную таблицу
                FillTable();
            }
        }

        private void tsbDeleteEmployeeRole_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show(this, "Удалить данные должности?", "Удаление должности",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var sorted = _roles.OrderBy(item => item.NameRole).ToList();
                var role = sorted[dgvEmployeeRoles.SelectedRows[0].Index];
                try
                {
                    _hotel.CheckEmployeeRoleUsed(role);
                    _roles.Remove(role);
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
