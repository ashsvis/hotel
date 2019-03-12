using System;
using System.Collections.Generic;

namespace Model
{
    [Serializable]
    public class Reservations : List<Reservation>
    {
        public void Add(Guid idClient, Guid idRoom, DateTime arrivalDate, DateTime departureDate)
        {
            base.Add(new Reservation
            {
                IdClient = idClient,
                IdRoom = idRoom,
                ArrivalDate = arrivalDate,
                DepartureDate = departureDate,
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
        public Guid IdReservation { get; set; } = Guid.NewGuid();
        public Guid IdClient { get; set; }
        public Guid IdRoom { get; set; }
        public DateTime ArrivalDate { get; set; } = new DateTime(1753, 1, 1);
        public DateTime DepartureDate { get; set; } = new DateTime(1753, 1, 1);

    }
}
