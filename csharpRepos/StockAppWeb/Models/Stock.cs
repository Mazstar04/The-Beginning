using System;

namespace StockAppWeb.Models
{
    public class Stock : BaseEntity
    {
        public int Category_Id;
        public string Category { get; set; }
        public string Brand { get; set;}
        public string Name { get; set; }
        public double CostPrice { get; set; }
        public double SellingPrice { get; set; }
        public string SKU { get; set; }
        public int Quantity { get; set; }
        public string Variation { get; set; }

        public Stock(int id, string brand, string name, double costPrice, double sellingPrice, string sKU, int quantity, string variation, DateTime created_at, int category_Id)
        {
            Id = id;
            CreatedAt = created_at;
            Brand = brand;
            Name = name;
            CostPrice = costPrice;
            SellingPrice = sellingPrice;
            SKU = sKU;
            Quantity = quantity;
            Variation = variation;
            Category_Id = category_Id;
        }

        public Stock(int id, string brand, string name, double costPrice, double sellingPrice, string sku, int quantity, DateTime created_at, string category)
        {
            Id = id;
            Brand = brand;
            Name = name;
            CostPrice = costPrice;
            SellingPrice = sellingPrice;
            SKU = sku;
            Quantity = quantity;
            CreatedAt = created_at;
            Category = category;
        }

        public override string ToString()
        {
            return $"{Id}\t{CreatedAt}\t{Brand}\t{Name}\t{CostPrice}\t{SellingPrice}\t{SKU}\t{Quantity}\t{Variation}\t{Category_Id}";
        }
    }
}
