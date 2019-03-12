using Model;
using System;
using System.Windows.Forms;

namespace Reception
{
    public partial class CategoryForm : Form
    {
        //счетчик режима обновления
        private int updating;
        private readonly Hotel _hotel;

        public Category Data { get; set; }

        public CategoryForm(Hotel hotel)
        {
            InitializeComponent();
            _hotel = hotel;
        }

        //занесение данных из объекта данных в контролы
        public void Build(Category data)
        {
            Data = data;

            updating++; //включаем режим обновления

            tbNameCategory.Text = data.NameCategory;

            updating--; //выключаем режим обновления
        }

        //Занесение данных из контролов в Data
        public void UpdateData()
        {
            if (updating > 0) return; //мы находимся в режиме обновления, не обрабатываем
            _hotel.CheckCategoryName(Data, tbNameCategory.Text);
            Data.NameCategory = tbNameCategory.Text;
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

        private void tbNameCategory_TextChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = !string.IsNullOrWhiteSpace(tbNameCategory.Text);
        }
    }
}
