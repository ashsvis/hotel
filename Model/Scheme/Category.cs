using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Model
{
    [Serializable]
    public class Categories: Dictionary<Guid, Category>, ISerializable
    {
        public Categories()
        {
        }

        public Categories(SerializationInfo info, StreamingContext context)
        {
            var keys = info.GetString("keys");
            foreach (var key in keys.Split(new[] { ',' }))
            {
                var guid = Guid.Parse(key);
                var category = new Category()
                {
                    IdCategory = guid,
                    NameCategory = info.GetString(key)
                };
                this.Add(guid, category);
            }
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("keys", string.Join(",", this.Keys));
            foreach (var key in this.Keys)
                info.AddValue(key.ToString(), this[key].NameCategory);
        }

        public void Add(Guid idCategory, string name)
        {
            var category = new Category
            {
                IdCategory = idCategory,
                NameCategory = name
            };
            base.Add(category.IdCategory, category);
        }

        public void Add(string name)
        {
            var category = new Category
            {
                NameCategory = name
            };
            base.Add(category.IdCategory, category);
        }

        public void Delete(Guid idCategory)
        {
            base.Remove(idCategory);
        }
    }

    [Serializable]
    public class Category
    {
        public Category()
        {
        }

        public Guid IdCategory { get; set; } = Guid.NewGuid();
        public string NameCategory { get; set; }

        public override string ToString()
        {
            return NameCategory;
        }

    }
}
