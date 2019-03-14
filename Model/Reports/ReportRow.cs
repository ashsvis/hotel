using System.Collections.Generic;

namespace Model
{
    public class ReportRows :List<ReportRow>
    {
        public void Add(params string[] args)
        {
            var row = new ReportRow();
            row.Add(args);
            base.Add(row);
        }
    }

    public class ReportRow
    {
        public List<string> Items { get; set; } = new List<string>();

        public void Add(params string[] args)
        {
            foreach (var item in args)
                Items.Add(item);
        }
    }
}
