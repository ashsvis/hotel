using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reception
{
    public partial class SelectPeriodForm : Form
    {
        public DateTime FirstDate { get { return dtpFirstDate.Value; } }
        public DateTime LastDate { get { return dtpLastDate.Value; } }

        public SelectPeriodForm()
        {
            InitializeComponent();
        }

        private void SelectPeriodForm_Load(object sender, EventArgs e)
        {
            var last = DateTime.Now;
            var first = new DateTime(last.Year, last.Month, 1);
            dtpFirstDate.Value = first;
            dtpLastDate.Value = last;
        }
    }
}
