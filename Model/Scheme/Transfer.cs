using System;
using System.Collections.Generic;

namespace Model
{
    /// <summary>
    /// Перечень трансферов
    /// </summary>
    [Serializable]
    public class Transfers : List<Transfer>
    {
        private readonly Hotel _hotel;

        public Transfers(Hotel hotel)
        {
            _hotel = hotel;
        }

        /// <summary>
        /// Добавить трансфер 
        /// </summary>
        /// <param name="idTransfer"></param>
        /// <param name="idReservation">Ссылка на бронирование</param>
        /// <param name="feedAddress">Адрес доставки</param>
        /// <param name="feedDateTime">Дата и время доставки</param>
        /// <param name="numberSeat">Количество посадочных мест</param>
        /// <returns></returns>
        public Transfer Add(Guid idTransfer, Guid idReservation, string feedAddress, DateTime feedDateTime, int numberSeat)
        {
            var transfer = new Transfer(_hotel)
            {
                IdTransfer = idTransfer,
                IdReservation = idReservation,
                FeedAddress = feedAddress,
                FeedDateTime = feedDateTime,
                NumberSeat = numberSeat
            };
            base.Add(transfer);
            return transfer;
        }

        /// <summary>
        /// Добавить трансфер 
        /// </summary>
        /// <param name="idReservation">Ссылка на бронирование</param>
        /// <param name="feedAddress">Адрес доставки</param>
        /// <param name="feedDateTime">Дата и время доставки</param>
        /// <param name="numberSeat">Количество посадочных мест</param>
        /// <returns></returns>
        public Transfer Add(Guid idReservation, string feedAddress, DateTime feedDateTime, int numberSeat)
        {
            var transfer = new Transfer(_hotel)
            {
                IdReservation = idReservation,
                FeedAddress = feedAddress,
                FeedDateTime = feedDateTime,
                NumberSeat = numberSeat
            };
            base.Add(transfer);
            return transfer;
        }

        /// <summary>
        /// Удалить трансфер
        /// </summary>
        /// <param name="idTransfer"></param>
        public void Delete(Guid idTransfer)
        {
            base.RemoveAll(item => item.IdTransfer == idTransfer);
        }
    }

    /// <summary>
    /// Запись о трансфере
    /// </summary>
    [Serializable]
    public class Transfer
    {
        private readonly Hotel _hotel;

        public Transfer(Hotel hotel)
        {
            _hotel = hotel;
        }

        public Guid IdTransfer { get; set; } = Guid.NewGuid();
        public Guid IdReservation { get; set; }                                 // Id размещения
        public string FeedAddress { get; set; }                                 // Адрес подачи
        public DateTime FeedDateTime { get; set; } = new DateTime(1753, 1, 1);  // Дата и время подачи
        public int NumberSeat { get; set; }                                     // Кол-во мест
    }
}
