using System;
using System.Collections.Generic;

namespace Model
{
    [Serializable]
    public class SeatKinds : List<KindOfSeat>
    {
        public void Add(string descriptor, int seats)
        {
            this.Add(new KindOfSeat { Descriptor = descriptor, NumberSeat = seats });
        }
    }

    [Serializable]
    public class KindOfSeat
    {
        public int NumberSeat { get; set; }
        public string Descriptor { get; set; }

        public override string ToString()
        {
            return Descriptor;
        }
    }
}
