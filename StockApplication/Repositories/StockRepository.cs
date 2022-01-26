using MySql.Data.MySqlClient;
using StockApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockApplication.Repositories
{
    public class StockRepository
    {
        MySqlConnection conn;
        public List<Stock> Stocks = new List<Stock>();
        public StockRepository(MySqlConnection connection)
        {
            conn = connection;
        }

        public List<Stock> ListAllStocks()
        {
            List<Stock> Stocks = new List<Stock>();
            try
            {
                conn.Open();
                string stockQuery = "Select id, brand, name, costPrice, sellingPrice, sku, quantity, variation, category_Id from stocks";
                MySqlCommand command = new MySqlCommand(stockQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    {
                        int id = reader.GetInt32(0);
                        string brand = reader.GetString(1);
                        string name = reader.GetString(2);
                        double costPrice = reader.GetDouble(3);
                        double sellingPrice = reader.GetDouble(4);
                        string sku = reader.GetString(5);
                        double quantity = reader.GetDouble(6);
                        string variation = reader.GetString(7);
                        int category_Id = reader.GetInt32(8);
                        Stock stock = new Stock(id, brand, name, costPrice, sellingPrice, sku, quantity, variation, category_Id);
                        Stocks.Add(stock);
                    }
                    // Console.WriteLine(reader[0] + "..." + reader[1]);
                }
                reader.Close();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Stocks;
        }
        public void GetStocks()
        {
            List<Stock> Stocks = ListAllStocks();
            foreach (var stock in Stocks)
            {
                Console.WriteLine($"Id: {stock.Id}  Stock Brand: {stock.Brand}  Stock Name: {stock.Name} Cost price: {stock.CostPrice}  Selling Price: {stock.SellingPrice}  Date: {stock.CreatedAt}");
            }
        }
        public Stock FindStock(int id)
        {
            Stock stock = null;
            try
            {
                conn.Open();
                string stockQuery = "Select id, brand, name, costPrice, sellingPrice, sku, quantity, variation, category_Id from Stocks where id = '" + id + "'";
                MySqlCommand command = new MySqlCommand(stockQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    {
                        string brand = reader.GetString(1);
                        string name = reader.GetString(2);
                        double costPrice = reader.GetDouble(3);
                        double sellingPrice = reader.GetDouble(4);
                        string sku = reader.GetString(5);
                        int quantity = reader.GetInt32(6);
                        string variation = reader.GetString(7);
                        int category_Id = reader.GetInt32(8);

                        stock = new Stock(id, brand, name, costPrice, sellingPrice, sku, quantity, variation, category_Id);
                    }
                    Console.WriteLine($"Id: {reader[0]}  Stock Brand: {reader[1]}  Stock Name: {reader[2]}  Cost Price: {reader[3]}  Selling Price: {reader[4]}  Quantity: {reader[6]}  Variation: {reader[7]}  Stock Category Id: {reader[8]}");
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            return stock;
        }
        public bool AddStock(int id, string brand, string name, double costPrice, double sellingPrice, string sku, double quantity, string variation, int category_Id)
        {
            try
            {
                conn.Open();
                string addStockQuery = "Insert into stocks (id, brand, name, costPrice, sellingPrice, sku, quantity, variation, category_Id)values ('" + id + "', '" + brand + "', '" + name + "', '" + costPrice + "', '" + sellingPrice + "', '" + sku + "', '" + quantity + "', '" + variation + "', '" + category_Id + "')";
                MySqlCommand command = new MySqlCommand(addStockQuery, conn);
                Console.WriteLine("Stock Added Sucessfully!");
                int Count = command.ExecuteNonQuery();
                if (Count > 0)
                {
                    conn.Close();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            return false;
        }


        public bool UpdateStock(int id, string brand, string name, double costPrice, double sellingPrice, string sku, double quantity, string variation, int category_Id)
        {
            var stock = FindStock(id);
            if (stock == null)
            {
                Console.WriteLine($"Stock with {id} does not exist");
            }
            try
            {
                conn.Open();
                string updateStockQuery = "update Stocks set brand = '" + brand + "', name = '" + name + "',costPrice = '" + costPrice + "',sellingPrice = '" + sellingPrice + "',sku= '" + sku + "',quantity = '" + quantity + "',variation = '" + variation + "',category_Id = '" + category_Id + "' where id = '" + id + "'";
                MySqlCommand command = new MySqlCommand(updateStockQuery, conn);
                Console.WriteLine("Stock Updated Sucessfully!");
                int Count = command.ExecuteNonQuery();
                if (Count > 0)
                {
                    conn.Close();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            return false;
        }

        public bool DeleteStock(int id)
        {
            var tock = FindStock(id);
            if (tock == null)
            {
                Console.WriteLine($"Stock with {id} does not exist");
            }
            try
            {
                conn.Open();
                string deleteStockQuery = "delete from Stocks where id = '" + id + "'";
                Console.WriteLine("Stock Deleted Sucessfully!");
                MySqlCommand command = new MySqlCommand(deleteStockQuery, conn);
                int Count = command.ExecuteNonQuery();
                if (Count > 0)
                {
                    conn.Close();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            return false;
        }
        public List<Stock> ListStock()
        {
            return Stocks;
        }
    }
}
