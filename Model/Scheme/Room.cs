using System;
using System.Collections.Generic;

namespace Model
{
    [Serializable]
    public class Rooms : List<Room>
    {
        public void Add(Guid idCategory, int numberSeat, int floor, decimal priceDay)
        {
            base.Add(new Room
            {
                IdCategory = idCategory,
                NumberSeat = numberSeat,
                Floor = floor,
                PriceDay = priceDay,
                Services = new Services()
            });
        }

        public void Delete(Guid idRoom)
        {
            base.RemoveAll(item => item.IdCategory == idRoom);
        }

    }

    [Serializable]
    public class Room
    {
        public Guid IdRoom { get; set; } = Guid.NewGuid();
        public Guid IdCategory { get; set; }
        public int NumberSeat { get; set; }
        public int Floor { get; set; }
        public decimal PriceDay { get; set; }
        public Services Services { get; set; } = new Services();
    }
}
