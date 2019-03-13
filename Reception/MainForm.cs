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
            CreateAndShowUserControl(rc);
        }

        private void CreateAndShowUserControl(UserControl rc)
        {
            if (panelView.Controls.Contains(rc)) return;
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
            CreateAndShowUserControl(rc);
        }

        private void tsmiClients_Click(object sender, EventArgs e)
        {
            var rc = new ClientsControl() { Dock = DockStyle.Fill };
            rc.Build(_hotel);
            CreateAndShowUserControl(rc);
        }

        private void tsmiReservations_Click(object sender, EventArgs e)
        {
            var rc = new ReservationsControl() { Dock = DockStyle.Fill };
            rc.Build(_hotel);
            CreateAndShowUserControl(rc);
        }

        private void tsmiServices_Click(object sender, EventArgs e)
        {
            var rc = new ServicesControl() { Dock = DockStyle.Fill };
            rc.Build(_hotel);
            CreateAndShowUserControl(rc);
        }

        private void tsmiCategories_Click(object sender, EventArgs e)
        {
            var rc = new CategoriesControl() { Dock = DockStyle.Fill };
            rc.Build(_hotel);
            CreateAndShowUserControl(rc);
        }

        private void tsmiEmployeeRoles_Click(object sender, EventArgs e)
        {
            var rc = new EmployeeRolesControl() { Dock = DockStyle.Fill };
            rc.Build(_hotel);
            CreateAndShowUserControl(rc);
        }

        private void tsmiTransfer_Click(object sender, EventArgs e)
        {
            var rc = new TransferControl() { Dock = DockStyle.Fill };
            rc.Build(_hotel);
            CreateAndShowUserControl(rc);
        }

        private void tsmiPayChannelsTV_Click(object sender, EventArgs e)
        {
            var rc = new PayChannelsControl() { Dock = DockStyle.Fill };
            rc.Build(_hotel);
            CreateAndShowUserControl(rc);
        }

        private void tsmiAccordancePayChannels_Click(object sender, EventArgs e)
        {
            var rc = new AccordancePayChannelsControl() { Dock = DockStyle.Fill };
            rc.Build(_hotel);
            CreateAndShowUserControl(rc);
        }
    }
}
