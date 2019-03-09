using System.Windows.Forms;
using Model;

namespace Reception
{
    public partial class EmployeesControl : UserControl
    {
        Hotel _hotel;
        RegistryStaff _staff;

        public EmployeesControl()
        {
            InitializeComponent();
        }

        //Занесение данных из _staff в контролы
        public void Build(Hotel hotel)
        {
            _hotel = hotel;
            _staff = _hotel.RegistryStaff;
            FillTable();
        }

        private void FillTable()
        {
            tsbChangeEmployee.Enabled = tsbDeleteEmployee.Enabled = false;
            // устанавливаем размер виртуальной таблицы
            dgvEmployees.RowCount = _staff.Count;
            // просим перерисовать таблицу
            dgvEmployees.Invalidate();
        }

        private void dgvEmployees_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            // для каждого столбца виртуальной таблицы
            switch (e.ColumnIndex)
            {
                case 0: // фамилия
                    e.Value = _staff[e.RowIndex].Surname;
                    break;
                case 1: // имя
                    e.Value = _staff[e.RowIndex].Name;
                    break;
                case 2: // отчество
                    e.Value = _staff[e.RowIndex].LastName;
                    break;
                case 3: // номер телефона
                    e.Value = _staff[e.RowIndex].PhoneNumber;
                    break;
            }
        }

        private void tsbNewEmployee_Click(object sender, System.EventArgs e)
        {
            var frm = new EmployeeForm(_hotel); // создаем форму
            frm.Build(new Employee(_hotel)); // создаём "пустого" сотрудника и заполняем контролы формы
            // показываем форму в диалоге
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                var employee = frm.Data; // получаем измененные данные сотрудника
                _staff.Add(employee); // добавляем в список сотрудников
                FillTable(); // перестраиваем таблицу
            }
        }

        private void tsbChangeEmployee_Click(object sender, System.EventArgs e)
        {
            var frm = new EmployeeForm(_hotel); // создаем форму
            frm.Build(_staff[dgvEmployees.SelectedRows[0].Index]); // заполняем контролы формы параметрами выбранного сотрудника
            // вызываем форму на редактирование
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                // обновляем виртуальную таблицу
                FillTable();
            }
        }

        private void tsbDeleteEmployee_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show(this, "Удалить данные сотрудника?", "Удаление данных сотрудника",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var employee = _staff[dgvEmployees.SelectedRows[0].Index];
                _staff.Remove(employee);
                // обновляем данные интерфейса
                FillTable();
            }
        }

        private void dgvEmployees_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            tsbChangeEmployee.Enabled = tsbDeleteEmployee.Enabled = true;
        }
    }
}
