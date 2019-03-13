using System;
using System.Collections.Generic;

namespace Model
{
    [Serializable]
    public class PayChannels : List<PayChannel>
    {

        public void Add(string nameChannel, decimal priceHour)
        {
            base.Add(new PayChannel
            {
                NameChannel = nameChannel,
                PriceHour = priceHour
            });
        }

        public void Delete(Guid idPayChannel)
        {
            base.RemoveAll(item => item.IdPayChannel == idPayChannel);
        }
    }

    [Serializable]
    public class PayChannel
    {
        public Guid IdPayChannel { get; set; } = Guid.NewGuid();
        public string NameChannel { get; set; }
        public decimal PriceHour { get; set; }

        public override string ToString()
        {
            return NameChannel;
        }
    }
}
