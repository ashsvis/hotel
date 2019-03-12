using System.Data;
using System.Linq;
using System.Windows.Forms;
using Model;

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
    }
}
