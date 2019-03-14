using System;
using System.Collections.Generic;

namespace Model
{
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

    }

    [Serializable]
    public class AccordancePayChannel
    {
        public Guid IdAccordancePayChannel { get; set; } = Guid.NewGuid();
        public Guid IdReservation { get; set; }
        public PayChannels PayChannels { get; set; } = new PayChannels();
    }
}
