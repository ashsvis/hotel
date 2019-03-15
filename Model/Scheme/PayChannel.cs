using System;
using System.Collections.Generic;

namespace Model
{
    /// <summary>
    /// Перечень платных каналов
    /// </summary>
    [Serializable]
    public class PayChannels : List<PayChannel>
    {
        /// <summary>
        /// Добавить канал
        /// </summary>
        /// <param name="idPayChannel"></param>
        /// <param name="nameChannel"></param>
        /// <param name="priceHour"></param>
        public void Add(Guid idPayChannel, string nameChannel, decimal priceHour)
        {
            base.Add(new PayChannel
            {
                IdPayChannel = idPayChannel,
                NameChannel = nameChannel,
                PriceHour = priceHour
            });
        }

        /// <summary>
        /// Добавить канал
        /// </summary>
        /// <param name="nameChannel"></param>
        /// <param name="priceHour"></param>
        public void Add(string nameChannel, decimal priceHour)
        {
            base.Add(new PayChannel
            {
                NameChannel = nameChannel,
                PriceHour = priceHour
            });
        }

        /// <summary>
        /// Удалить канал
        /// </summary>
        /// <param name="idPayChannel"></param>
        public void Delete(Guid idPayChannel)
        {
            base.RemoveAll(item => item.IdPayChannel == idPayChannel);
        }
    }

    /// <summary>
    /// Запись о канале
    /// </summary>
    [Serializable]
    public class PayChannel
    {
        public Guid IdPayChannel { get; set; } = Guid.NewGuid();
        public string NameChannel { get; set; } // наименование канала
        public decimal PriceHour { get; set; } // цена за час

        public override string ToString()
        {
            return NameChannel;
        }
    }
}
