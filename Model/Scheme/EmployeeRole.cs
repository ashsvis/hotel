using System;
using System.Collections.Generic;

namespace Model
{
    [Serializable]
    public class EmployeeRoles : List<EmployeeRole>
    {
        public void Add(string nameRole, decimal salary, AllowedOperations allowedOperations)
        {
            base.Add(new EmployeeRole
            {
                NameRole = nameRole,
                Salary = salary,
                AllowedOperations = allowedOperations
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
        public AllowedOperations AllowedOperations { get; set; }

        public override string ToString()
        {
            return NameRole;
        }
    }

    /// <summary>
    /// Допустимые операции над базой данных
    /// </summary>
    [Serializable]
    [Flags]
    public enum AllowedOperations : uint
    {
        None = 0x0,             // ничего нельзя
        ManageEmployees = 0x1,  // может работать с базой сотрудников и связанными с ними
        ManageClients = 0x2,    // может работать с базой клиентов и связанными с ними
        // новые режимы добавлять здесь

        All = 0xffffffff,   // всё можно
    }
}
