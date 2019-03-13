using System;
using System.Collections.Generic;

namespace Model
{
    [Serializable]
    public class Reservations : List<Reservation>
    {
        private readonly Hotel _hotel;

        public Reservations(Hotel hotel)
        {
            _hotel = hotel;
        }

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

        public void Delete(Guid idArrival)
        {
            base.RemoveAll(item => item.IdReservation == idArrival);
        }
    }

    [Serializable]
    public class Reservation
    {
        private readonly Hotel _hotel;

        public Reservation(Hotel hotel)
        {
            _hotel = hotel;
        }

        public Guid IdReservation { get; set; } = Guid.NewGuid();
        public Guid IdClient { get; set; }
        public Guid IdRoom { get; set; }
        public DateTime ArrivalDate { get; set; } = new DateTime(1753, 1, 1);
        public DateTime DepartureDate { get; set; } = new DateTime(1753, 1, 1);
        public Guid IdEmployee { get; set; }

        public override string ToString()
        {
            var client = _hotel.GetClient(IdClient);
            var room = _hotel.GetRoom(IdRoom);
            var category = _hotel.Categories[room.IdCategory].NameCategory;
            return string.Format($"{category} №{room.RoomNumber}, {client.Surname} {client.Name}, заезд c {ArrivalDate.ToShortDateString()}");
        }
    }
}
