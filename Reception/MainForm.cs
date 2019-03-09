using Model;
using System;
using System.Windows.Forms;

namespace Reception
{
    public partial class MainForm : Form
    {
        private Categories _categories;
        private Services _services;
        private Rooms _rooms;

        public MainForm()
        {
            InitializeComponent();
            _categories = new Categories();
            _categories.Add("Эконом");
            _categories.Add("Семейный");
            _categories.Add("Стандарт");
            _categories.Add("Люкс");
            _categories.Add("Апартаменты");
            _services = new Services();
            _services.Add("Интернет");
            _services.Add("Телевизор");
            _services.Add("Фен");
            _services.Add("Душевая");
            _services.Add("Кондиционер");
            _services.Add("Мини бар");
            _services.Add("Сейф");
            _rooms = new Rooms();
            //_rooms.Add(_categories[0].IdCategory, 2, 1, 3500);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiTuningRooms_Click(object sender, EventArgs e)
        {
            var rc = new RoomsControl() { Dock = DockStyle.Fill };
            rc.Build(_categories, _services, _rooms);
            panelView.Controls.Add(rc);
            if (panelView.Controls.Count > 1)
                panelView.Controls.RemoveAt(0);
   
        }
    }
}
