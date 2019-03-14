using System.Collections.Generic;

namespace Model
{
    public class ReportColumns : List<string>
    {
        public void Add(params string[] args)
        {
            foreach (var item in args)
                base.Add(item);
        }
    }
}
