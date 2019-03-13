using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    [Serializable]
    public enum EmployeeOrdered
    {
        None,
        BySurname,
        ByPhone,
    }

    [Serializable]
    public class RegistryStaff: List<Employee>
    {
        private readonly Hotel _hotel;

        public RegistryStaff(Hotel hotel)
        {
            _hotel = hotel;
        }

        public void Add(string surname, string name, string lastname, string phoneNumber, Guid idEmployeeRole)
        {
            base.Add(new Employee(_hotel)
            {
                Surname = surname,
                Name = name,
                LastName = lastname,
                PhoneNumber = phoneNumber,
                IdEmployeeRole = idEmployeeRole
            });
        }

        public void Delete(Guid idEmployee)
        {
            base.RemoveAll(item => item.IdEmployee == idEmployee);
        }

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

        public List<Employee> OrderedBySurname()
        {
            return ((IEnumerable<Employee>)this).OrderBy(item => string.Concat(item.Surname, item.Name, item.LastName)).ToList();
        }

        public List<Employee> OrderedByPhone()
        {
            return ((IEnumerable<Employee>)this).OrderBy(item => item.PhoneNumber).ToList();
        }
    }

    [Serializable]
    public class Employee
    {
        private readonly Hotel _hotel;

        public Employee(Hotel hotel)
        {
            _hotel = hotel;
        }

        public Guid IdEmployee { get; set; } = Guid.NewGuid();
        public string Surname { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Guid IdEmployeeRole { get; set; }

        public override string ToString()
        {
            return string.Format($"{Surname} {Name} {LastName}");
        }
    }
}
