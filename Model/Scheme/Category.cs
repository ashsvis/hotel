using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Model
{
    /// <summary>
    /// Список категорий номеров
    /// </summary>
    [Serializable]
    public class Categories: Dictionary<Guid, Category>, ISerializable
    {
        public Categories()
        {
        }

        /// <summary>
        /// Конструктор для настраиваемой сериализации
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
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

        /// <summary>
        /// Метод для настраиваемой сериализации
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("keys", string.Join(",", this.Keys));
            foreach (var key in this.Keys)
                info.AddValue(key.ToString(), this[key].NameCategory);
        }

        /// <summary>
        /// Добавить категорию
        /// </summary>
        /// <param name="idCategory"></param>
        /// <param name="name"></param>
        public void Add(Guid idCategory, string name)
        {
            var category = new Category
            {
                IdCategory = idCategory,
                NameCategory = name
            };
            base.Add(category.IdCategory, category);
        }

        /// <summary>
        /// Добавить категорию
        /// </summary>
        /// <param name="name"></param>
        public void Add(string name)
        {
            var category = new Category
            {
                NameCategory = name
            };
            base.Add(category.IdCategory, category);
        }

        /// <summary>
        /// Удалить категорию
        /// </summary>
        /// <param name="idCategory"></param>
        public void Delete(Guid idCategory)
        {
            base.Remove(idCategory);
        }
    }

    /// <summary>
    /// Категория номера
    /// </summary>
    [Serializable]
    public class Category
    {
        public Category()
        {
        }

        public Guid IdCategory { get; set; } = Guid.NewGuid();
        public string NameCategory { get; set; } // имя категории

        public override string ToString()
        {
            return NameCategory;
        }

    }
}
