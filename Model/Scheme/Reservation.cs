using System;
using System.Collections.Generic;

namespace Model
{
    [Serializable]
    public class Reservations : List<Reservation>
    {
        public void Add(Guid idClient, Guid idRoom, DateTime arrivalDate, DateTime departureDate, Guid idStuff)
        {
            base.Add(new Reservation
            {
                IdClient = idClient,
                IdRoom = idRoom,
                ArrivalDate = arrivalDate,
                DepartureDate = departureDate,
                IdStuff = idStuff
            });
        }

        public void Delete(Guid idReservation)
        {
            base.RemoveAll(item => item.IdReservation == idReservation);
        }
    }

    [Serializable]
    public class Reservation
    {
        public Guid IdReservation { get; set; } = Guid.NewGuid();
        public Guid IdClient { get; set; }
        public Guid IdRoom { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public Guid IdStuff { get; set; }
    }
}
