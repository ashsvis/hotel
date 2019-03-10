using System;
using System.Collections.Generic;

namespace Model
{
    [Serializable]
    public class Arrivals : List<Arrival>
    {
        public void Add(Guid idClient, Guid idRoom, DateTime arrivalDate, DateTime departureDate)
        {
            base.Add(new Arrival
            {
                IdClient = idClient,
                IdRoom = idRoom,
                ArrivalDate = arrivalDate,
                DepartureDate = departureDate,
                Services = new Services()
            });
        }

        public void Delete(Guid idArrival)
        {
            base.RemoveAll(item => item.IdArrival == idArrival);
        }
    }

    [Serializable]
    public class Arrival
    {
        public Guid IdArrival { get; set; } = Guid.NewGuid();
        public Guid IdClient { get; set; }
        public Guid IdRoom { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public Services Services { get; set; } = new Services();

    }
}
