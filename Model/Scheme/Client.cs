using System;
using System.Collections.Generic;

namespace Model
{
    [Serializable]
    public class Clients : List<Client>
    {
        public void Add(string surname, string name, string lastname, 
            DateTime birthday, string city, string phoneNumber, string passport, int numberChild)
        {
            base.Add(new Client
            {
                Surname = surname,
                Name = name,
                LastName = lastname,
                Birthday = birthday,
                City = city,
                PhoneNumber = phoneNumber,
                Passport = passport,
                NumberChild = numberChild
            });
        }

        public void Delete(Guid idClient)
        {
            base.RemoveAll(item => item.IdClient == idClient);
        }
    }

    [Serializable]
    public class Client
    {
        public Guid IdClient { get; set; } = Guid.NewGuid();
        public string Surname { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Passport { get; set; }
        public int NumberChild { get; set; }
    }
}
