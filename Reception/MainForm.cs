using Model;
using System;
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
    }
}
