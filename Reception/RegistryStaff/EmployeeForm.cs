using Model;
using System.Windows.Forms;

namespace Reception
{
    public partial class EmployeeForm : Form
    {
        //счетчик режима обновления
        private int updating;

        public Employee Data { get; set; }

        public EmployeeForm(Hotel hotel)
        {
            InitializeComponent();

        }

        //занесение данных из объекта данных в контролы
        public void Build(Employee data)
        {
            Data = data;

            updating++; //включаем режим обновления


            updating--; //выключаем режим обновления
        }

        //Занесение данных из контролов в Data
        public void UpdateData()
        {
            if (updating > 0) return; //мы находимся в режиме обновления, не обрабатываем

        }
    }
}
