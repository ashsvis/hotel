using Model;
using System;
using System.IO;
using System.Windows.Forms;

namespace Reception
{
    public partial class MainForm : Form
    {
        private Hotel _hotel = new Hotel();

        public MainForm()
        {
            InitializeComponent();
            _hotel.BuildData();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var fileName = Path.ChangeExtension(Application.ExecutablePath, ".dat");
            if (File.Exists(fileName))
                _hotel = SaverLoader.LoadFromFile(fileName);
            CenterToScreen();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiTuningRooms_Click(object sender, EventArgs e)
        {
            var rc = new RoomsControl() { Dock = DockStyle.Fill };
            rc.Build(_hotel);
            panelView.Controls.Add(rc);
            if (panelView.Controls.Count > 1)
                panelView.Controls.RemoveAt(0); 
        }

        private void tsmiSaveToFile_Click(object sender, EventArgs e)
        {
            var fileName = Path.ChangeExtension(Application.ExecutablePath, ".dat");
            SaverLoader.SaveToFile(fileName, _hotel);
        }

        private void tsmiEmployees_Click(object sender, EventArgs e)
        {
            var rc = new EmployeesControl() { Dock = DockStyle.Fill };
            rc.Build(_hotel);
            panelView.Controls.Add(rc);
            if (panelView.Controls.Count > 1)
                panelView.Controls.RemoveAt(0);
        }
    }
}
