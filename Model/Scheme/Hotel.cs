using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    /// <summary>
    /// Главный класс модели
    /// </summary>
    [Serializable]
    public class Hotel
    {
        public Hotel()
        {
            Rooms = new Rooms(this); // список комнат
            RegistryStaff = new RegistryStaff(this); // список сотрудников
            Reservations = new Reservations(this); // список бронирования
            Transfers = new Transfers(this); // список трансфера
        }

        public Categories Categories { get; set; } = new Categories(); // категории
        public Services Services { get; set; } = new Services(); // услуги
        public Rooms Rooms { get; set; } // номера
        public EmployeeRoles EmployeeRoles { get; set; } = new EmployeeRoles(); // должности сотрудников
        public RegistryStaff RegistryStaff { get; set; } // сотрудники
        public Clients Clients { get; set; } = new Clients(); // клиенты
        public Reservations Reservations { get; set; } // бронирование
        public Transfers Transfers { get; set; } // трансферы
        public PayChannels PayChannels { get; set; } = new PayChannels(); // платные каналы
        public AccordancePayChannels AccordancePayChannels { get; set; } = new AccordancePayChannels(); // подписки на каналы

        /// <summary>
        /// Данные для тестирования
        /// </summary>
        public void BuildData()
        {
            //EmployeeRoles.Add("Управляющий", 15000, AllowedOperations.All);
            //EmployeeRoles.Add("Регистратор", 12000, AllowedOperations.All ^ AllowedOperations.ManageEmployees);
            //EmployeeRoles.Add("Горничная", 8500, AllowedOperations.None);

            //Categories.Add("Эконом");
            //Categories.Add("Семейный");
            //Categories.Add("Стандарт");
            //Categories.Add("Люкс");
            //Categories.Add("Апартаменты");

            //Services.Add("Интернет", 5);
            //Services.Add("Телевизор", 5);
            //Services.Add("Душевая", 15);
            //Services.Add("Фен", 1);
            //Services.Add("Кондиционер", 10);
            //Services.Add("Мини бар", 100);
            //Services.Add("Сейф", 100);

        }

        /// <summary>
        /// Проверить на использование платного канала
        /// </summary>
        /// <param name="channel"></param>
        public void CheckPayChannelUsed(PayChannel channel)
        {
            if (AccordancePayChannels.Any(item => item.PayChannels.Any(p => p.IdPayChannel == channel.IdPayChannel)))
                throw new Exception("Этот канал ещё используется!");
        }

        /// <summary>
        /// Проверить на использование бронирования
        /// </summary>
        /// <param name="reservation"></param>
        public void CheckReservationUsed(Reservation reservation)
        {
            if (Transfers.Any(item => item.IdReservation == reservation.IdReservation) ||
                AccordancePayChannels.Any(item => item.IdReservation == reservation.IdReservation))
                throw new Exception("Эти данные о бронировании ещё используются!");
        }

        /// <summary>
        /// Проверить на использование сотрудника в списке бронирования
        /// </summary>
        /// <param name="employee"></param>
        public void CheckEmployeeUsed(Employee employee)
        {
            if (Reservations.Any(item => item.IdEmployee == employee.IdEmployee))
                throw new Exception("Эта запись сотрудника ещё используется!");
        }

        /// <summary>
        /// Проверить уникальность названия канала
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="name"></param>
        public void CheckPayChannelName(PayChannel channel, string name)
        {
            if (PayChannels.Any(item => item != channel && item.NameChannel == name))
                throw new Exception("Это название канала уже используется!");
        }

        /// <summary>
        /// Проверить уникальность названия должности
        /// </summary>
        /// <param name="role"></param>
        /// <param name="name"></param>
        public void CheckEmployeeRoleName(EmployeeRole role, string name)
        {
            if (EmployeeRoles.Any(item => item != role && item.NameRole == name))
                throw new Exception("Это название должности уже используется!");
        }

        /// <summary>
        /// Проверка на использование должности у сотрудников
        /// </summary>
        /// <param name="role"></param>
        public void CheckEmployeeRoleUsed(EmployeeRole role)
        {
            if (RegistryStaff.Any(item => item.IdEmployeeRole == role.IdEmployeeRole))
                throw new Exception("Это должность ещё используется!");
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
            if (Reservations.Any(r => r.IdRoom == room.IdRoom))
                throw new Exception("Этот номер ещё используется!");
        }

        /// <summary>
        /// Проверка на использование записи клиента в заселении
        /// </summary>
        /// <param name="client"></param>
        public void CheckClientUsed(Client client)
        {
            if (Reservations.Any(r => r.IdClient == client.IdClient))
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
        /// Получить ссылку на заселение по его Id
        /// </summary>
        /// <param name="reservationId"></param>
        /// <returns></returns>
        public Reservation GetReservation(Guid reservationId)
        {
            return this.Reservations.FirstOrDefault(item => item.IdReservation == reservationId);
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
        /// Получить ссылку на сотрудника по его Id
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public Employee GetEmployee(Guid employeeId)
        {
            return this.RegistryStaff.FirstOrDefault(item => item.IdEmployee == employeeId);
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
            return Reservations.Where(item => 
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
        /// Получить список сотрудников, имеющих право работать с программой
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetUsers()
        {
            var list = new List<Employee>();
            list.AddRange(GetAdministrators());
            list.AddRange(GetRegistrators());
            return list.OrderBy(item => string.Concat(item.Surname, item.Name, item.LastName)).Distinct().ToList();
        }

        /// <summary>
        /// Администратор в системе определён
        /// </summary>
        /// <returns></returns>
        public bool IsAdministratorDefined()
        {
            return GetRegistrators().Count > 0;
        }

        /// <summary>
        /// Получить список сотрудников, имеющих право регистрировать клиентов
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetRegistrators()
        {
            return RegistryStaff.Where(item => GetEmployeeRole(item.IdEmployeeRole)
                                .AllowedOperations.HasFlag(AllowedOperations.ManageClients))
                                .OrderBy(item => string.Concat(item.Surname,item.Name,item.LastName)).ToList();
        }

        /// <summary>
        /// Получить список сотрудников, имеющих право регистрировать сотрудников
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetAdministrators()
        {
            return RegistryStaff.Where(item => GetEmployeeRole(item.IdEmployeeRole)
                                .AllowedOperations.HasFlag(AllowedOperations.ManageEmployees))
                                .OrderBy(item => string.Concat(item.Surname, item.Name, item.LastName)).ToList();
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
