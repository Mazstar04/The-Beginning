using System;

namespace Inheritance
{
    public class Product : BaseEntity
    {
        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}