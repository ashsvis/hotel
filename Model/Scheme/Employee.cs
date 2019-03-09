using System;
using System.Collections.Generic;

namespace Model
{
    [Serializable]
    public class RegistryStaff: List<Employee>
    {
        private readonly Hotel _hotel;

        public RegistryStaff(Hotel hotel)
        {
            _hotel = hotel;
        }

        public void Add(string surname, string name, string lastname, string phoneNumber)
        {
            base.Add(new Employee(_hotel)
            {
                Surname = surname,
                Name = name,
                LastName = lastname,
                PhoneNumber = phoneNumber
            });
        }

        public void Delete(Guid idEmployee)
        {
            base.RemoveAll(item => item.IdEmployee == idEmployee);
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
    }
}
