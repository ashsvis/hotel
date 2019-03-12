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
        public EmployeeRoles EmployeeRoles { get; set; } = new EmployeeRoles();
        public RegistryStaff RegistryStaff { get; set; }
        public Clients Clients { get; set; } = new Clients();
        public Reservations Reservations { get; set; } = new Reservations();
        public Reservations Arrivals { get; set; } = new Reservations();

        public void BuildData()
        {
            EmployeeRoles.Add("Управляющий", 15000, AllowedOperations.All);
            EmployeeRoles.Add("Регистратор", 12000, AllowedOperations.All ^ AllowedOperations.ManageEmployees);
            EmployeeRoles.Add("Горничная", 8500, AllowedOperations.None);

            Seats.Add("Одноместный", 1);
            Seats.Add("Двухместный", 2);
            Seats.Add("Трёхместный", 3);

            Categories.Add("Эконом");
            Categories.Add("Семейный");
            Categories.Add("Стандарт");
            Categories.Add("Люкс");
            Categories.Add("Апартаменты");

            Services.Add("Интернет", 5);
            Services.Add("Телевизор", 5);
            Services.Add("Душевая", 15);
            Services.Add("Фен", 1);
            Services.Add("Кондиционер", 10);
            Services.Add("Мини бар", 100);
            Services.Add("Сейф", 100);

            for (var floor = 1; floor < 5; floor++)
            {
                var roomNumber = 1;
                foreach (var category in Categories)
                {
                    Room room;
                    switch (category.Value.NameCategory)
                    {
                        case "Эконом":
                            for (var i = 0; i < 3; i++)
                            {
                                room = Rooms.Add(category.Value.IdCategory, 3, floor, 3500);
                                room.RoomNumber = (floor*100 + roomNumber++).ToString();
                                room.Services.AddRange(Services.Take(1));
                            }
                            break;
                        case "Стандарт":
                            for (var i = 0; i < 10; i++)
                            {
                                room = Rooms.Add(category.Value.IdCategory, 2, floor, 4500);
                                room.RoomNumber = (floor * 100 + roomNumber++).ToString();
                                room.Services.AddRange(Services.Take(3));
                            }
                            break;
                        case "Семейный":
                            for (var i = 0; i < 2; i++)
                            {
                                room = Rooms.Add(category.Value.IdCategory, 3, floor, 5500);
                                room.RoomNumber = (floor * 100 + roomNumber++).ToString();
                                room.Services.AddRange(Services.Take(5));
                            }
                            break;
                        case "Люкс":
                            for (var i = 0; i < 2; i++)
                            {
                                room = Rooms.Add(category.Value.IdCategory, 1, floor, 8700);
                                room.RoomNumber = (floor * 100 + roomNumber++).ToString();
                                room.Services.AddRange(Services);
                            }
                            break;
                        case "Апартаменты":
                            room = Rooms.Add(category.Value.IdCategory, 1, floor, 15300);
                            room.RoomNumber = (floor * 100 + roomNumber++).ToString();
                            room.Services.AddRange(Services);
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Проверить уникальность названия категории
        /// </summary>
        /// <param name="category"></param>
        /// <param name="name"></param>
        public void CheckCategoryName(Category category, string name)
        {
            if (Categories.Any(item => item.Value != category && item.Value.NameCategory == name))
                throw new Exception("Это название категории уже используется!");
        }

        /// <summary>
        /// Проверка на использование категории в комнатах
        /// </summary>
        /// <param name="category"></param>
        public void CheckCategoryUsed(Category category)
        {
            if (Rooms.Any(item => item.IdCategory == category.IdCategory))
                throw new Exception("Это категория ещё используется!");
        }

        /// <summary>
        /// Проверка на использование услуги в комнатах
        /// </summary>
        /// <param name="service"></param>
        public void CheckServiceUsed(Service service)
        {
            if (Rooms.Any(item => item.Services.Any(s => s.IdService == service.IdService)))
                throw new Exception("Это услуга ещё используется!");
        }

        /// <summary>
        /// Проверка на использование комнаты в заселении
        /// </summary>
        /// <param name="room"></param>
        public void CheckRoomUsed(Room room)
        {
            if (Arrivals.Any(r => r.IdRoom == room.IdRoom))
                throw new Exception("Этот номер ещё используется!");
        }

        /// <summary>
        /// Проверка на использование записи клиента в заселении
        /// </summary>
        /// <param name="client"></param>
        public void CheckClientUsed(Client client)
        {
            if (Arrivals.Any(r => r.IdClient == client.IdClient))
                throw new Exception("Эта запись о клиенте ещё используется!");
        }

        /// <summary>
        /// Проверить уникальность названия услуги
        /// </summary>
        /// <param name="service"></param>
        /// <param name="name"></param>
        public void CheckServiceName(Service service, string name)
        {
            if (Services.Any(item => item != service && item.NameService == name))
                throw new Exception("Это название услуги уже используется!");
        }

        /// <summary>
        /// Подсчет стоимости номера с услугами за период  
        /// </summary>
        /// <param name="room">номер</param>
        /// <param name="first">начало периода</param>
        /// <param name="last">конец периода</param>
        /// <returns></returns>
        public decimal CalcArrivalPrice(Room room, DateTime first, DateTime last)
        {
            var span = last.Date - first.Date;
            var price = room.CalcPriceDayTotal() * span.Days;
            return price;
        }

        /// <summary>
        /// Получить ссылку на роль сотрудника по её Id
        /// </summary>
        /// <param name="employeeRoleId"></param>
        /// <returns></returns>
        public EmployeeRole GetEmployeeRole(Guid employeeRoleId)
        {
            return this.EmployeeRoles.FirstOrDefault(item => item.IdEmployeeRole == employeeRoleId);
        }

        /// <summary>
        /// Получить ссылку на клиента по его Id
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public Client GetClient(Guid clientId)
        {
            return this.Clients.FirstOrDefault(item => item.IdClient == clientId);
        }

        /// <summary>
        /// Получить ссылку на номер по его Id
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns></returns>
        public Room GetRoom(Guid roomId)
        {
            return this.Rooms.FirstOrDefault(item => item.IdRoom == roomId);
        }

        /// <summary>
        /// Сколько проживает в номере в промежуток времени
        /// </summary>
        /// <param name="room">комната</param>
        /// <param name="first">начало периода</param>
        /// <param name="last">конец периода</param>
        /// <returns></returns>
        public int RoomUsed(Room room, DateTime first, DateTime last)
        {
            return Arrivals.Where(item => 
                                  item.ArrivalDate >= first && item.ArrivalDate <= last ||
                                  item.DepartureDate >= first && item.DepartureDate <= last)
                           .Count(item => item.IdRoom == room.IdRoom);
        }

        /// <summary>
        /// Номер полностью занят в промежуток времени
        /// </summary>
        /// <param name="room">комната</param>
        /// <param name="first">начало периода</param>
        /// <param name="last">конец перода</param>
        /// <returns></returns>
        public bool RoomBusy(Room room, DateTime first, DateTime last)
        {
            return RoomUsed(room, first, last) == room.NumberSeat;
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
