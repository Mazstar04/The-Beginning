using System;

namespace Entities
{
    public class Stock : BaseEntity
    {
        public int Category_Id;
        public string Brand { get; set; }
        public string Name { get; set; }
        public double CostPrice { get; set; }
        public double SellingPrice { get; set; }
        public string SKU { get; set; }
        public double Quantity { get; set; }
        public string Variation { get; set; }
        
        public Stock(int id, string brand, string name, double costPrice, double sellingPrice, string sku, double quantity, string variation, int category_Id)
        {
            Id = id;
            Brand = brand;
            Name = name;
            CostPrice = costPrice;
            SellingPrice = sellingPrice;
            SKU = sku;
            Quantity = quantity;
            Variation = variation;
            CreatedAt = DateTime.Now;
            Category_Id = category_Id;
        }

        public override string ToString()
        {
            return  $"{Id}-{Brand}-{Name}-{CostPrice}-{SellingPrice}-{SKU}-{Quantity}-{Variation}-{CreatedAt}-{Category_Id}";
        }

        internal static Stock StringToStock(string stockString)
        {
            var props = stockString.Split('-');

            int id = Convert.ToInt32(props[0]);

            int costPrice = Convert.ToInt32(props[3]);
            
            int sellingPrice = Convert.ToInt32(props[4]);
            
            double quantity = Convert.ToDouble(props[6]);
            
            DateTime created_At = Convert.ToDateTime(props[8]);

            int category_Id = Convert.ToInt32(props[9]);

            Stock stock = new Stock(id, props[1], props[2], costPrice, sellingPrice, props[5], quantity, props[7], category_Id);
            return stock;
        }

    }
}