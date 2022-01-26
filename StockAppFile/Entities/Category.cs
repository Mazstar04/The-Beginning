using System;
namespace Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
            CreatedAt = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{Id}\t{Name}\t{CreatedAt}";
        }
        internal static Category StringToCategory(string categoryString)
        {
            var props = categoryString.Split("\t");

            int id = int.Parse(props[0]);

            DateTime created_At = DateTime.Parse(props[2]);

            return new Category(id, props[1]);
        }
    }
}