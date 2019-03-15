using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    /// <summary>
    /// Перечисление для указания сортировки для таблицы клиентов
    /// </summary>
    [Serializable]
    public enum ClientOrdered
    {
        None,
        BySurname,
        ByPhone,
        ByBirthday,
        ByCity,
    }

    /// <summary>
    /// Список клиентов
    /// </summary>
    [Serializable]
    public class Clients : List<Client>
    {
        public void Add(Guid idClient, string surname, string name, string lastname,
            DateTime birthday, string city, string phoneNumber, string passport, int numberChild = 0)
        {
            base.Add(new Client
            {
                IdClient = idClient,
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

        /// <summary>
        /// Метод для выдачи сортированных списков
        /// </summary>
        /// <param name="ordered"></param>
        /// <returns></returns>
        public List<Client> SortedBy(ClientOrdered ordered = ClientOrdered.None)
        {
            switch (ordered)
            {
                case ClientOrdered.BySurname:
                    return OrderedBySurname();
                case ClientOrdered.ByPhone:
                    return OrderedByPhone();
                case ClientOrdered.ByBirthday:
                    return OrderedByBirthday();
                case ClientOrdered.ByCity:
                    return OrderedByCity();
                default:
                    return this;
            }
        }

        /// <summary>
        /// Сортировка по фамилии, имени
        /// </summary>
        /// <returns></returns>
        public List<Client> OrderedBySurname()
        {
            return ((IEnumerable<Client>)this).OrderBy(item => string.Concat(item.Surname, item.Name, item.LastName)).ToList();
        }

        /// <summary>
        /// Сортировка по номеру телифона
        /// </summary>
        /// <returns></returns>
        public List<Client> OrderedByPhone()
        {
            return ((IEnumerable<Client>)this).OrderBy(item => item.PhoneNumber).ToList();
        }

        /// <summary>
        /// Сортировка по дате рождения
        /// </summary>
        /// <returns></returns>
        public List<Client> OrderedByBirthday()
        {
            return ((IEnumerable<Client>)this).OrderBy(item => item.Birthday).ToList();
        }

        /// <summary>
        /// Сортировка по городу проживания
        /// </summary>
        /// <returns></returns>
        public List<Client> OrderedByCity()
        {
            return ((IEnumerable<Client>)this).OrderBy(item => item.City).ToList();
        }
    }

    /// <summary>
    /// Запись о клиенте
    /// </summary>
    [Serializable]
    public class Client
    {
        public Guid IdClient { get; set; } = Guid.NewGuid();
        public string Surname { get; set; } // Фамилия
        public string Name { get; set; }    // Имя
        public string LastName { get; set; }    // Отчество
        public DateTime Birthday { get; set; } = new DateTime(1753, 1, 1); // дата рождения
        public string City { get; set; } // город проживания
        public string PhoneNumber { get; set; } // номер телефона
        public string Passport { get; set; } // паспорт
        public int NumberChild { get; set; } // количество детей

        public override string ToString()
        {
            return string.Format($"{Surname} {Name} {LastName}");
        }
    }
}
