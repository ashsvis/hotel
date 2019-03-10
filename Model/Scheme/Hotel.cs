using System;
using System.Linq;

namespace Model
{
    [Serializable]
    public class Hotel
    {
        public Hotel()
        {
            Rooms = new Rooms(this);
            RegistryStaff = new RegistryStaff(this);
        }

        public Categories Categories { get; set; } = new Categories();
        public Services Services { get; set; } = new Services();
        public SeatKinds Seats { get; set; } = new SeatKinds();
        public Rooms Rooms { get; set; }
        public RegistryStaff RegistryStaff { get; set; }
        public Clients Clients { get; set; } = new Clients();
        public Reservations Reservations { get; set; } = new Reservations();
        public Arrivals Arrivals { get; set; } = new Arrivals();

        public void BuildData()
        {
            Categories.Add("Эконом");
            Categories.Add("Семейный");
            Categories.Add("Стандарт");
            Categories.Add("Люкс");
            Categories.Add("Апартаменты");
            Services.Add("Интернет");
            Services.Add("Телевизор");
            Services.Add("Фен");
            Services.Add("Душевая");
            Services.Add("Кондиционер");
            Services.Add("Мини бар");
            Services.Add("Сейф");
            Seats.Add("Двухместный", 2);
            Seats.Add("Одноместный", 1);
            Seats.Add("Трёхместный", 3);
        }

        /// <summary>
        /// Проверка на дублирование данных паспорта клиента
        /// </summary>
        /// <param name="client"></param>
        /// <param name="passport"></param>
        public void CheckClientPassport(Client client, string passport)
        {
            if (Clients.Any(item => item != client && item.Passport == passport))
                throw new Exception("Этот номер паспорта постояльца уже используется!");
        }

        /// <summary>
        /// Проверка на дублирование полного имени клиента
        /// </summary>
        /// <param name="client"></param>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="lastname"></param>
        public void CheckClientFullName(Client client, string surname, string name, string lastname)
        {
            if (Clients.Any(item => item != client && item.Surname == surname && item.Name == name && item.LastName == lastname))
                throw new Exception("Фамилия, имя и отчество постояльца уже используется!");
        }

        /// <summary>
        /// Проверка на дублирование номера телефона клиента
        /// </summary>
        /// <param name="client"></param>
        /// <param name="phoneNumber"></param>
        public void CheckClientPhoneNumber(Client client, string phoneNumber)
        {
            if (Clients.Any(item => item != client && item.PhoneNumber == phoneNumber))
                throw new Exception("Этот номер телефона постояльца уже используется!");
        }

        /// <summary>
        /// Проверка на дублирование полного имени работника
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="lastname"></param>
        public void CheckEmployeeFullName(Employee employee, string surname, string name, string lastname)
        {
            if (RegistryStaff.Any(item => item != employee && item.Surname == surname && item.Name == name && item.LastName == lastname))
                throw new Exception("Фамилия, имя и отчество сотрудника уже используется!");
        }

        /// <summary>
        /// Проверка на дублирование номера телефона сотрудника
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="phoneNumber"></param>
        public void CheckEmployeePhoneNumber(Employee employee, string phoneNumber)
        {
            if (RegistryStaff.Any(item => item != employee && item.PhoneNumber == phoneNumber))
                throw new Exception("Этот номер телефона сотрудника уже используется!");
        }

        /// <summary>
        /// Проверка на дублирование номера комнаты
        /// </summary>
        /// <param name="room"></param>
        /// <param name="roomNumber"></param>
        public void CheckRoomNumber(Room room, string roomNumber)
        {
            if (Rooms.Any(item => item != room && item.RoomNumber == roomNumber))
                throw new Exception("Этот номер комнаты уже используется!");
        }
    }
}
