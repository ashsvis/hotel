using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    [Serializable]
    public enum RoomOrdered
    {
        None,
        ByFloor,
        ByCategory,
        ByNumberSeat,
        ByPriceDay
    }

    [Serializable]
    public class Rooms : List<Room>
    {
        private readonly Hotel _hotel;

        public Rooms(Hotel hotel)
        {
            _hotel = hotel;
        }

        public void Add(Guid idCategory, int numberSeat, int floor, decimal priceDay)
        {
            base.Add(new Room(_hotel)
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

        public List<Room> FilteredByFloor(int floor = 0, RoomOrdered ordered = RoomOrdered.None)
        {
            switch (ordered)
            {
                case RoomOrdered.ByFloor:
                    if (floor == 0) return OrderedByFloor(this);
                    return OrderedByFloor(this.Where(item => item.Floor == floor).ToList());
                case RoomOrdered.ByCategory:
                    if (floor == 0) return OrderedByCategory(this);
                    return OrderedByCategory(this.Where(item => item.Floor == floor).ToList());
                case RoomOrdered.ByNumberSeat:
                    if (floor == 0) return OrderedByNumberSeat(this);
                    return OrderedByNumberSeat(this.Where(item => item.Floor == floor).ToList());
                case RoomOrdered.ByPriceDay:
                    if (floor == 0) return OrderedByPriceDay(this);
                    return OrderedByPriceDay(this.Where(item => item.Floor == floor).ToList());
                default:
                    if (floor == 0) return this;
                    return this.Where(item => item.Floor == floor).ToList();
            }
        }

        public List<Room> OrderedByFloor(List<Room> rooms)
        {
            return ((IEnumerable<Room>)rooms).OrderBy(item => item.Floor).ToList();
        }

        public List<Room> OrderedByCategory(List<Room> rooms)
        {
            return ((IEnumerable<Room>)rooms).OrderBy(item => GetNameCategory(item)).ToList();
        }

        private object GetNameCategory(Room item)
        {
            return _hotel.Categories[item.IdCategory].NameCategory;
        }

        public List<Room> OrderedByNumberSeat(List<Room> rooms)
        {
            return ((IEnumerable<Room>)rooms).OrderBy(item => item.NumberSeat).ToList();
        }

        public List<Room> OrderedByPriceDay(List<Room> rooms)
        {
            return ((IEnumerable<Room>)rooms).OrderBy(item => item.PriceDay).ToList();
        }
    }

    [Serializable]
    public class Room
    {
        private readonly Hotel _hotel;

        public Room(Hotel hotel)
        {
            _hotel = hotel;
        }

        public Guid IdRoom { get; set; } = Guid.NewGuid();
        public Guid IdCategory { get; set; }
        public int NumberSeat { get; set; }
        public int Floor { get; set; }
        public decimal PriceDay { get; set; }
        public Services Services { get; set; } = new Services();
    }
}
