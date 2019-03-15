using System;
using System.Collections.Generic;

namespace Model
{
    /// <summary>
    /// Список бронирования
    /// </summary>
    [Serializable]
    public class Reservations : List<Reservation>
    {
        private readonly Hotel _hotel;

        public Reservations(Hotel hotel)
        {
            _hotel = hotel;
        }

        /// <summary>
        /// Добавить бронирование
        /// </summary>
        /// <param name="idArrival"></param>
        /// <param name="idClient">Ссылка на клиента</param>
        /// <param name="idRoom">Ссылка на комнату</param>
        /// <param name="arrivalDate">Дата заезда</param>
        /// <param name="departureDate">Дата выезда</param>
        /// <param name="idEmployee">Ссылка на сотрудника</param>
        public void Add(Guid idArrival, Guid idClient, Guid idRoom, DateTime arrivalDate, DateTime departureDate, Guid idEmployee)
        {
            base.Add(new Reservation(_hotel)
            {
                IdReservation = idArrival,
                IdClient = idClient,
                IdRoom = idRoom,
                ArrivalDate = arrivalDate,
                DepartureDate = departureDate,
                IdEmployee = idEmployee
            });
        }

        /// <summary>
        /// Добавить бронирование
        /// </summary>
        /// <param name="idClient">Ссылка на клиента</param>
        /// <param name="idRoom">Ссылка на комнату</param>
        /// <param name="arrivalDate">Дата заезда</param>
        /// <param name="departureDate">Дата выезда</param>
        /// <param name="idEmployee">Ссылка на сотрудника</param>
        public void Add(Guid idClient, Guid idRoom, DateTime arrivalDate, DateTime departureDate, Guid idEmployee)
        {
            base.Add(new Reservation(_hotel)
            {
                IdClient = idClient,
                IdRoom = idRoom,
                ArrivalDate = arrivalDate,
                DepartureDate = departureDate,
                IdEmployee = idEmployee
            });
        }

        /// <summary>
        /// Удаление бронирования
        /// </summary>
        /// <param name="idArrival"></param>
        public void Delete(Guid idArrival)
        {
            base.RemoveAll(item => item.IdReservation == idArrival);
        }
    }

    /// <summary>
    /// Запись о бронировании
    /// </summary>
    [Serializable]
    public class Reservation
    {
        private readonly Hotel _hotel;

        public Reservation(Hotel hotel)
        {
            _hotel = hotel;
        }

        public Guid IdReservation { get; set; } = Guid.NewGuid();
        public Guid IdClient { get; set; } // ссылка на клиента
        public Guid IdRoom { get; set; } // ссылка на номер
        public DateTime ArrivalDate { get; set; } = new DateTime(1753, 1, 1); // дата заезда
        public DateTime DepartureDate { get; set; } = new DateTime(1753, 1, 1); // дата выезда
        public Guid IdEmployee { get; set; } // ссылка на сотрудника

        public override string ToString()
        {
            var client = _hotel.GetClient(IdClient);
            var room = _hotel.GetRoom(IdRoom);
            var category = _hotel.Categories[room.IdCategory].NameCategory;
            return string.Format($"{category} №{room.RoomNumber}, {client.Surname} {client.Name}, заезд c {ArrivalDate.ToShortDateString()}");
        }
    }
}
