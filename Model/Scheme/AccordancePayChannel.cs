using System;
using System.Linq;
using System.Collections.Generic;

namespace Model
{
    /// <summary>
    /// Список подключенных платных каналов
    /// </summary>
    [Serializable]
    public class AccordancePayChannels : List<AccordancePayChannel>
    {

        public AccordancePayChannel Add(Guid idAccordancePayChannel, Guid idReservation)
        {
            var room = new AccordancePayChannel
            {
                IdAccordancePayChannel = idAccordancePayChannel,
                IdReservation = idReservation,
                PayChannels = new PayChannels()
            };
            base.Add(room);
            return room;
        }

        public AccordancePayChannel Add(Guid idReservation)
        {
            var room = new AccordancePayChannel
            {
                IdReservation = idReservation,
                PayChannels = new PayChannels()
            };
            base.Add(room);
            return room;
        }

        public void Delete(Guid idAccordancePayChannel)
        {
            base.RemoveAll(item => item.IdAccordancePayChannel == idAccordancePayChannel);
        }

        /// <summary>
        /// Сортируем по имени клиента
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        public List<AccordancePayChannel> OrderByClient(Hotel hotel)
        {
            return (this).OrderBy(item => string.Concat(GetClient(hotel, item).Surname, 
                                                        GetClient(hotel, item).Name, 
                                                        GetClient(hotel, item).LastName)).ToList();
        }

        private static Client GetClient(Hotel hotel, AccordancePayChannel item)
        {
            return hotel.GetClient(hotel.GetReservation(item.IdReservation).IdClient);
        }
    }

    /// <summary>
    /// Запись о подключенных каналах 
    /// </summary>
    [Serializable]
    public class AccordancePayChannel
    {
        public Guid IdAccordancePayChannel { get; set; } = Guid.NewGuid();
        public Guid IdReservation { get; set; } // ссылка на запись о бронировании
        public PayChannels PayChannels { get; set; } = new PayChannels(); // список подключенных каналов
    }
}
