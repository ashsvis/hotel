using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Model;

namespace Reception
{
    public partial class CategoriesControl : UserControl
    {
        Hotel _hotel;
        Categories _categories;

        public CategoriesControl()
        {
            InitializeComponent();
        }

        //Занесение данных из _services в контролы
        public void Build(Hotel hotel)
        {
            _hotel = hotel;
            _categories = _hotel.Categories;
            FillTable();
        }

        private void FillTable()
        {
            tsbChangeCategory.Enabled = tsbDeleteCategory.Enabled = false;
            // устанавливаем размер виртуальной таблицы
            dgvCategories.RowCount = _categories.Count;
            // просим перерисовать таблицу
            dgvCategories.Invalidate();
        }

        private void dgvCategories_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            var sorted = _categories.Values.OrderBy(item => item.NameCategory).ToList();
            if (sorted.Count == 0) return;
            // для каждого столбца виртуальной таблицы
            switch (e.ColumnIndex)
            {
                case 0: // наименование категории
                    e.Value = sorted[e.RowIndex].NameCategory;
                    break;
            }
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbChangeCategory.Enabled = tsbDeleteCategory.Enabled = true;
        }

        private void tsbNewCategory_Click(object sender, System.EventArgs e)
        {
            var frm = new CategoryForm(_hotel); // создаем форму
            frm.Build(new Category()); // создаём "пустую" категорию и заполняем контролы формы
            // показываем форму в диалоге
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                var category = frm.Data;
                _categories.Add(category.IdCategory, category); // добавляем в список категорий
                FillTable(); // перестраиваем таблицу
            }
        }

        private void tsbChangeCategory_Click(object sender, System.EventArgs e)
        {
            var frm = new CategoryForm(_hotel); // создаем форму
            var sorted = _categories.Values.OrderBy(item => item.NameCategory).ToList();
            frm.Build(sorted[dgvCategories.SelectedRows[0].Index]); // заполняем контролы формы параметрами выбранной категории
            // вызываем форму на редактирование
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                // обновляем виртуальную таблицу
                FillTable();
            }
        }

        private void tsbDeleteCategory_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show(this, "Удалить данные категории?", "Удаление категории",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var sorted = _categories.Values.OrderBy(item => item.NameCategory).ToList();
                var category = sorted[dgvCategories.SelectedRows[0].Index];
                try
                {
                    _hotel.CheckCategoryUsed(category);
                    _categories.Remove(category.IdCategory);
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
