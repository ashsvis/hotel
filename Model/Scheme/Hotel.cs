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
        /// Проверка на дублирование номера телефона
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="phoneNumber"></param>
        public void CheckPhoneNumber(Employee employee, string phoneNumber)
        {
            if (RegistryStaff.Any(item => item != employee && item.PhoneNumber == phoneNumber))
                throw new Exception("Этот номер телефона уже используется!");
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
