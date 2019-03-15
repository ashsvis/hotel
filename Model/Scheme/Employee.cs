using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    /// <summary>
    /// Перечень для сортировки сотрудников
    /// </summary>
    [Serializable]
    public enum EmployeeOrdered
    {
        None,
        BySurname,
        ByPhone,
    }

    /// <summary>
    /// Список сотрудников
    /// </summary>
    [Serializable]
    public class RegistryStaff: List<Employee>
    {
        private readonly Hotel _hotel;

        public RegistryStaff(Hotel hotel)
        {
            _hotel = hotel;
        }

        /// <summary>
        /// Добавить сотрудника
        /// </summary>
        /// <param name="idEmployee"></param>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="lastname"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="idEmployeeRole">ссылка на должность</param>
        /// <param name="password">хеш пароля</param>
        public void Add(Guid idEmployee, string surname, string name, string lastname, string phoneNumber, Guid idEmployeeRole, string password)
        {
            base.Add(new Employee(_hotel)
            {
                IdEmployee = idEmployee,
                Surname = surname,
                Name = name,
                LastName = lastname,
                PhoneNumber = phoneNumber,
                IdEmployeeRole = idEmployeeRole,
                Password = password
            });
        }

        /// <summary>
        /// Добавить сотрудника
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="lastname"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="idEmployeeRole">ссылка на должность</param>
        /// <param name="password">хеш пароля</param>
        public void Add(string surname, string name, string lastname, string phoneNumber, Guid idEmployeeRole, string password)
        {
            base.Add(new Employee(_hotel)
            {
                Surname = surname,
                Name = name,
                LastName = lastname,
                PhoneNumber = phoneNumber,
                IdEmployeeRole = idEmployeeRole,
                Password = password
            });
        }

        /// <summary>
        /// Удалить сотрудника
        /// </summary>
        /// <param name="idEmployee"></param>
        public void Delete(Guid idEmployee)
        {
            base.RemoveAll(item => item.IdEmployee == idEmployee);
        }

        /// <summary>
        /// Сортировка списка сотрудников
        /// </summary>
        /// <param name="ordered"></param>
        /// <returns></returns>
        public List<Employee> SortedBy(EmployeeOrdered ordered = EmployeeOrdered.None)
        {
            switch (ordered)
            {
                case EmployeeOrdered.BySurname:
                    return OrderedBySurname();
                case EmployeeOrdered.ByPhone:
                    return OrderedByPhone();
                default:
                    return this;
            }
        }

        /// <summary>
        /// Сортировка по фамилии
        /// </summary>
        /// <returns></returns>
        public List<Employee> OrderedBySurname()
        {
            return ((IEnumerable<Employee>)this).OrderBy(item => string.Concat(item.Surname, item.Name, item.LastName)).ToList();
        }

        /// <summary>
        /// Сортировка по телефону
        /// </summary>
        /// <returns></returns>
        public List<Employee> OrderedByPhone()
        {
            return ((IEnumerable<Employee>)this).OrderBy(item => item.PhoneNumber).ToList();
        }
    }

    /// <summary>
    /// Запись о сотруднике
    /// </summary>
    [Serializable]
    public class Employee
    {
        private readonly Hotel _hotel;

        public Employee(Hotel hotel)
        {
            _hotel = hotel;
        }

        public Guid IdEmployee { get; set; } = Guid.NewGuid();
        public string Surname { get; set; } // фамилия
        public string Name { get; set; } // имя
        public string LastName { get; set; } // отчество
        public string PhoneNumber { get; set; } // номер телефона
        public Guid IdEmployeeRole { get; set; } // ссылка на должность
        public string Password { get; set; } // хеш пароля

        public override string ToString()
        {
            var role = _hotel.GetEmployeeRole(IdEmployeeRole);
            return string.Format($"{Surname} {Name} {LastName} ({role})");
        }
    }
}
