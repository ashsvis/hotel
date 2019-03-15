using System;
using System.Collections.Generic;

namespace Model
{
    /// <summary>
    /// Список должностей
    /// </summary>
    [Serializable]
    public class EmployeeRoles : List<EmployeeRole>
    {
        /// <summary>
        /// Добавить должность
        /// </summary>
        /// <param name="idEmployeeRole"></param>
        /// <param name="nameRole">Должность</param>
        /// <param name="salary">Зарплата</param>
        /// <param name="allowedOperations">Права доступа в программе</param>
        public void Add(Guid idEmployeeRole, string nameRole, decimal salary, AllowedOperations allowedOperations)
        {
            base.Add(new EmployeeRole
            {
                IdEmployeeRole = idEmployeeRole,
                NameRole = nameRole,
                Salary = salary,
                AllowedOperations = allowedOperations
            });
        }

        /// <summary>
        /// Добавить должность
        /// </summary>
        /// <param name="nameRole">Должность</param>
        /// <param name="salary">Зарплата</param>
        /// <param name="allowedOperations">Права доступа в программе</param>
        public void Add(string nameRole, decimal salary, AllowedOperations allowedOperations)
        {
            base.Add(new EmployeeRole
            {
                NameRole = nameRole,
                Salary = salary,
                AllowedOperations = allowedOperations
            });
        }

        /// <summary>
        /// Удаление должности
        /// </summary>
        /// <param name="idEmployeeRole"></param>
        public void Delete(Guid idEmployeeRole)
        {
            base.RemoveAll(item => item.IdEmployeeRole == idEmployeeRole);
        }

    }

    /// <summary>
    /// Запись о должности
    /// </summary>
    [Serializable]
    public class EmployeeRole
    {
        public Guid IdEmployeeRole { get; set; } = Guid.NewGuid();
        public string NameRole { get; set; } // наименование
        public decimal Salary { get; set; } // зарплата
        public AllowedOperations AllowedOperations { get; set; } // права доступа

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
