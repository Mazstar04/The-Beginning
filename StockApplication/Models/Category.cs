using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockApplication.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public Category(int id, string name, DateTime created_at)
        {
            Id = id;
            Name = name;
            CreatedAt = created_at;
        }
        public override string ToString()
        {
            return $"{Id}\t{Name}\t{CreatedAt}";
        }
    }
}
