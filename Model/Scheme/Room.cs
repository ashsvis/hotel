using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    /// <summary>
    /// Перечисление для сортировки
    /// </summary>
    [Serializable]
    public enum RoomOrdered
    {
        None,
        ByFloor,
        ByCategory,
        ByNumberSeat,
        ByPriceDay,
        ByRoomNumber
    }

    /// <summary>
    /// Список номеров
    /// </summary>
    [Serializable]
    public class Rooms : List<Room>
    {
        private readonly Hotel _hotel;

        public Rooms(Hotel hotel)
        {
            _hotel = hotel;
        }

        /// <summary>
        /// Добавить комнату
        /// </summary>
        /// <param name="idRoom"></param>
        /// <param name="idCategory">Категория</param>
        /// <param name="numberSeat">Количество мест</param>
        /// <param name="floor">Номер этажа</param>
        /// <param name="priceDay">Цена за сутки</param>
        /// <param name="roomNumber">Номер комнаты</param>
        /// <returns></returns>
        public Room Add(Guid idRoom, Guid idCategory, int numberSeat, int floor, decimal priceDay, string roomNumber)
        {
            var room = new Room(_hotel)
            {
                IdRoom = idRoom,
                IdCategory = idCategory,
                NumberSeat = numberSeat,
                Floor = floor,
                PriceDay = priceDay,
                RoomNumber = roomNumber,
                Services = new Services()
            };
            base.Add(room);
            return room;
        }

        /// <summary>
        /// Добавить комнату
        /// </summary>
        /// <param name="idCategory">Категория</param>
        /// <param name="numberSeat">Количество мест</param>
        /// <param name="floor">Номер этажа</param>
        /// <param name="priceDay">Цена за сутки</param>
        /// <param name="roomNumber">Номер комнаты</param>
        /// <returns></returns>
        public Room Add(Guid idCategory, int numberSeat, int floor, decimal priceDay, string roomNumber)
        {
            var room = new Room(_hotel)
            {
                IdCategory = idCategory,
                NumberSeat = numberSeat,
                Floor = floor,
                PriceDay = priceDay,
                RoomNumber = roomNumber,
                Services = new Services()
            };
            base.Add(room);
            return room;
        }

        /// <summary>
        /// Получить комнату по id
        /// </summary>
        /// <param name="idRoom"></param>
        /// <returns></returns>
        public Room Get(Guid idRoom)
        {
            return _hotel.Rooms.FirstOrDefault(item => item.IdRoom == idRoom);
        }

        /// <summary>
        /// Удалить комнату
        /// </summary>
        /// <param name="idRoom"></param>
        public void Delete(Guid idRoom)
        {
            base.RemoveAll(item => item.IdCategory == idRoom);
        }

        /// <summary>
        /// Фильтрование
        /// </summary>
        /// <param name="floor">Номер этажа</param>
        /// <param name="ordered">Переключатель сортировки</param>
        /// <returns></returns>
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
                case RoomOrdered.ByRoomNumber:
                    if (floor == 0) return OrderedByRoomNumber(this);
                    return OrderedByRoomNumber(this.Where(item => item.Floor == floor).ToList());
                default:
                    if (floor == 0) return this;
                    return this.Where(item => item.Floor == floor).ToList();
            }
        }

        /// <summary>
        /// Сортировка по номеру этажа
        /// </summary>
        /// <param name="rooms">Список комнат</param>
        /// <returns></returns>
        public List<Room> OrderedByFloor(List<Room> rooms)
        {
            return ((IEnumerable<Room>)rooms).OrderBy(item => item.Floor).ToList();
        }

        /// <summary>
        /// Сортировка по номеру комнаты
        /// </summary>
        /// <param name="rooms">Список комнат</param>
        /// <returns></returns>
        public List<Room> OrderedByRoomNumber(List<Room> rooms)
        {
            return ((IEnumerable<Room>)rooms).OrderBy(item => item.RoomNumber).ToList();
        }

        /// <summary>
        /// Сортировка по категории номера
        /// </summary>
        /// <param name="rooms"></param>
        /// <returns></returns>
        public List<Room> OrderedByCategory(List<Room> rooms)
        {
            return ((IEnumerable<Room>)rooms).OrderBy(item => GetNameCategory(item)).ToList();
        }

        /// <summary>
        /// Получить имя категории
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private object GetNameCategory(Room item)
        {
            return _hotel.Categories[item.IdCategory].NameCategory;
        }

        /// <summary>
        /// Сортировка по количеству мест
        /// </summary>
        /// <param name="rooms"></param>
        /// <returns></returns>
        public List<Room> OrderedByNumberSeat(List<Room> rooms)
        {
            return ((IEnumerable<Room>)rooms).OrderBy(item => item.NumberSeat).ToList();
        }

        /// <summary>
        /// Сортировка по цене
        /// </summary>
        /// <param name="rooms"></param>
        /// <returns></returns>
        public List<Room> OrderedByPriceDay(List<Room> rooms)
        {
            return ((IEnumerable<Room>)rooms).OrderBy(item => item.PriceDay).ToList();
        }
    }

    /// <summary>
    /// Запись о комнате
    /// </summary>
    [Serializable]
    public class Room
    {
        private readonly Hotel _hotel;

        public Room(Hotel hotel)
        {
            _hotel = hotel;
        }

        public Guid IdRoom { get; set; } = Guid.NewGuid();
        public Guid IdCategory { get; set; } // ссылка на категорию
        public int NumberSeat { get; set; } // количество мест
        public int Floor { get; set; } // номер этажа
        public decimal PriceDay { get; set; } // цена за сутки
        public Services Services { get; set; } = new Services(); // перечень подключаемых услуг
        public string RoomNumber { get; set; } // номер комнаты

        public override string ToString()
        {
            return RoomNumber;
        }

        /// <summary>
        /// Подсчёт цены номера с учётом подключённых услуг
        /// </summary>
        /// <returns></returns>
        public decimal CalcPriceDayTotal()
        {
            var price = this.PriceDay;
            foreach (var service in this.Services)
                price += service.PriceDay;
            return price;
        }
    }
}
