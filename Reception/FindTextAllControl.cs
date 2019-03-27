using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Reception
{
    public partial class FindTextAllControl : UserControl
    {
        Hotel _hotel;

        public FindTextAllControl()
        {
            InitializeComponent();
        }

        public void Build(Hotel hotel)
        {
            _hotel = hotel;
            tstbSample.Focus();
        }

        private void tsbFind_Click(object sender, EventArgs e)
        {
            dgvFindResults.DataSource = _hotel.Find(tstbSample.Text);
        }
    }
}
