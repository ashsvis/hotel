using System;
using System.Collections.Generic;

namespace Model
{
    [Serializable]
    public class Services : List<Service>
    {
        public void Add(Guid idService, string name, decimal priceDay)
        {
            base.Add(new Service
            {
                IdService = idService,
                NameService = name,
                PriceDay = priceDay
            });
        }

        public void Add(string name, decimal priceDay)
        {
            base.Add(new Service
            {
                NameService = name,
                PriceDay = priceDay
            });
        }

        public void Delete(Guid idService)
        {
            base.RemoveAll(item => item.IdService == idService);
        }

    }

    [Serializable]
    public class Service
    {
        public Guid IdService { get; set; } = Guid.NewGuid();
        public string NameService { get; set; }
        public decimal PriceDay { get; set; }

        public override string ToString()
        {
            return string.Format($"{NameService} ({PriceDay} р/с)");
        }
    }
}
