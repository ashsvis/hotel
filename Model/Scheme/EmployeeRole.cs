using System;
using System.Collections.Generic;

namespace Model.Scheme
{
    [Serializable]
    public class EmployeeRoles : List<EmployeeRole>
    {
        public void Add(string nameRole, decimal salary)
        {
            base.Add(new EmployeeRole
            {
                NameRole = nameRole,
                Salary = salary
            });
        }

        public void Delete(Guid idEmployeeRole)
        {
            base.RemoveAll(item => item.IdEmployeeRole == idEmployeeRole);
        }

    }

    [Serializable]
    public class EmployeeRole
    {
        public Guid IdEmployeeRole { get; set; } = Guid.NewGuid();
        public string NameRole { get; set; }
        public decimal Salary { get; set; }
        public AllowOperations AllowOperations { get; set; }

        public override string ToString()
        {
            return NameRole;
        }
    }
}
