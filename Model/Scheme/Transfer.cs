using System;
using System.Collections.Generic;

namespace Model.Scheme
{
    [Serializable]
    public class Transfers : List<Transfer>
    {
        private readonly Hotel _hotel;

        public Transfers(Hotel hotel)
        {
            _hotel = hotel;
        }

        public Transfer Add(Guid idReservation, string feedAddress, DateTime feedDateTime, int numberSeat, decimal price)
        {
            var transfer = new Transfer(_hotel)
            {
                IdReservation = idReservation,
                FeedAddress = feedAddress,
                FeedDateTime = feedDateTime,
                NumberSeat = numberSeat,
                Price = price
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
        public Guid IdReservation { get; set; }     // Id размещения
        public string FeedAddress { get; set; }     // адрес подачи
        public DateTime FeedDateTime { get; set; }  // дата и время подачи
        public int NumberSeat { get; set; }         // кол-во мест
        public decimal Price { get; set; }
    }
}
