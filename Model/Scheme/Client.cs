using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    [Serializable]
    public enum ClientOrdered
    {
        None,
        BySurname,
        ByPhone,
        ByBirthday,
        ByCity,
    }

    [Serializable]
    public class Clients : List<Client>
    {
        public void Add(string surname, string name, string lastname, 
            DateTime birthday, string city, string phoneNumber, string passport, int numberChild = 0)
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

        public List<Client> SortedBy(ClientOrdered ordered = ClientOrdered.None)
        {
            switch (ordered)
            {
                case ClientOrdered.BySurname:
                    return OrderedBySurname(this);
                case ClientOrdered.ByPhone:
                    return OrderedByPhone(this);
                case ClientOrdered.ByBirthday:
                    return OrderedByBirthday(this);
                case ClientOrdered.ByCity:
                    return OrderedByCity(this);
                default:
                    return this;
            }
        }

        public List<Client> OrderedBySurname(List<Client> clients)
        {
            return ((IEnumerable<Client>)clients).OrderBy(item => string.Concat(item.Surname, item.Name, item.LastName)).ToList();
        }

        public List<Client> OrderedByPhone(List<Client> clients)
        {
            return ((IEnumerable<Client>)clients).OrderBy(item => item.PhoneNumber).ToList();
        }

        public List<Client> OrderedByBirthday(List<Client> clients)
        {
            return ((IEnumerable<Client>)clients).OrderBy(item => item.Birthday).ToList();
        }

        public List<Client> OrderedByCity(List<Client> clients)
        {
            return ((IEnumerable<Client>)clients).OrderBy(item => item.City).ToList();
        }
    }

    [Serializable]
    public class Client
    {
        public Guid IdClient { get; set; } = Guid.NewGuid();
        public string Surname { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; } = new DateTime(1753, 1, 1);
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Passport { get; set; }
        public int NumberChild { get; set; }
    }
}
