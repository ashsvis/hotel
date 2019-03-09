using System;
using System.Collections.Generic;

namespace Model
{
    [Serializable]
    public class Services : List<Service>
    {
        public void Add(string name)
        {
            base.Add(new Service
            {
                NameService = name
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

        public override string ToString()
        {
            return NameService;
        }
    }
}
