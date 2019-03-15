using System;
using System.Collections.Generic;

namespace Model
{
    /// <summary>
    /// Перечень услуг
    /// </summary>
    [Serializable]
    public class Services : List<Service>
    {
        /// <summary>
        /// Добавить услугу
        /// </summary>
        /// <param name="idService"></param>
        /// <param name="name">Наименование</param>
        /// <param name="priceDay">Цена за сутки</param>
        public void Add(Guid idService, string name, decimal priceDay)
        {
            base.Add(new Service
            {
                IdService = idService,
                NameService = name,
                PriceDay = priceDay
            });
        }

        /// <summary>
        /// Добавить услугу
        /// </summary>
        /// <param name="name">Наименование</param>
        /// <param name="priceDay">Цена за сутки</param>
        public void Add(string name, decimal priceDay)
        {
            base.Add(new Service
            {
                NameService = name,
                PriceDay = priceDay
            });
        }

        /// <summary>
        /// Удалить услугу
        /// </summary>
        /// <param name="idService"></param>
        public void Delete(Guid idService)
        {
            base.RemoveAll(item => item.IdService == idService);
        }

    }

    /// <summary>
    /// Запись об услуге
    /// </summary>
    [Serializable]
    public class Service
    {
        public Guid IdService { get; set; } = Guid.NewGuid();
        public string NameService { get; set; } // наименование
        public decimal PriceDay { get; set; } // цена за сутки использования

        public override string ToString()
        {
            return string.Format($"{NameService} ({PriceDay} р/с)");
        }
    }
}
