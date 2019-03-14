using System.Windows.Forms;
using Model;
using System.Linq;

namespace Reception
{
    public partial class ReportViewControl : UserControl
    {
        Hotel _hotel;
        Report _report;

        public ReportViewControl()
        {
            InitializeComponent();
        }

        public void Build(Hotel hotel, Report report)
        {
            _hotel = hotel;
            _report = report;
            lbReportCaption.Text = report.Caption;
            lvReport.Columns.Clear();
            lvReport.Items.Clear();
            foreach (var column in report.ReportColumns)
            {
                lvReport.Columns.Add(column, 200);
            }
            foreach (var row in report.ReportRows)
            {
                var lvi = new ListViewItem
                {
                    Text = row.Items[0]
                };
                foreach (var item in row.Items.Skip(1))
                    lvi.SubItems.Add(item);
                lvReport.Items.Add(lvi);
            }
        }
    }
}
