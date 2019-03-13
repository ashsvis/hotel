using System;
using System.Collections.Generic;

namespace Model
{
    [Serializable]
    public class Transfers : List<Transfer>
    {
        private readonly Hotel _hotel;

        public Transfers(Hotel hotel)
        {
            _hotel = hotel;
        }

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
    }

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
        public string FeedAddress { get; set; }                                 // адрес подачи
        public DateTime FeedDateTime { get; set; } = new DateTime(1753, 1, 1);  // дата и время подачи
        public int NumberSeat { get; set; }                                     // кол-во мест
    }
}
