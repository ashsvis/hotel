using System.Collections.Generic;

namespace Model
{
    public class Report
    {
        public string Caption { get; set; } = string.Empty;
        public ReportColumns ReportColumns { get; set; } = new ReportColumns();
        public ReportRows ReportRows { get; set; } = new ReportRows();

        public void Clear()
        {
            Caption = string.Empty;
            ReportColumns.Clear();
            ReportRows.Clear();
        }
    }
}
