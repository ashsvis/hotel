using System;
using System.Collections.Generic;

namespace Model
{
    [Serializable]
    public class Categories: List<Category>
    {
        public void Add(string name)
        {
            base.Add(new Category
            {
                NameCategory = name
            });
        }

        public void Delete(Guid idCategory)
        {
            base.RemoveAll(item => item.IdCategory == idCategory);
        }
    }

    [Serializable]
    public class Category
    {
        public Guid IdCategory { get; set; } = Guid.NewGuid();
        public string NameCategory { get; set; }

        public override string ToString()
        {
            return NameCategory;
        }

    }
}
