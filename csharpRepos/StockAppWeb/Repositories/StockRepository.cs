using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using StockAppWeb.Models;

namespace StockAppWeb.Repositories
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

                string stockQuery = "SELECT s.id, s.brand, s.name, s.cost_price, s.selling_price, s.sku, s.quantity, s.created_at, c.name AS category FROM stocks s INNER JOIN categories c ON c.id = s.category_id;";

                MySqlCommand command = new MySqlCommand(stockQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    {
                        int id = reader.GetInt32(0);

                        string brand = reader.GetString(1);

                        string name = reader.GetString(2);

                        double cost_price = reader.GetDouble(3);

                        double selling_price = reader.GetDouble(4);

                        string sku = reader.GetString(5);

                        int quantity = reader.GetInt32(6);

                        DateTime created_at = reader.GetDateTime(7);

                        string category = reader.GetString(8);

                        Stock stock = new Stock(id, brand, name, cost_price, selling_price, sku, quantity, created_at, category);

                        Stocks.Add(stock);

                    }
                }
                reader.Close();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            return Stocks;
        }

        public List<Stock> ListExpensiveStocks()
        {
            List<Stock> Stocks = new List<Stock>();
            try
            {
                conn.Open();

                string stockQuery = "select * from stocks where selling_price > 1000";

                MySqlCommand command = new MySqlCommand(stockQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    {
                        int id = reader.GetInt32(0);

                        string brand = reader.GetString(1);

                        string name = reader.GetString(2);

                        double cost_price = reader.GetDouble(3);

                        double selling_price = reader.GetDouble(4);

                        string sku = reader.GetString(5);

                        int quantity = reader.GetInt32(6);

                        string variation = reader.GetString(7);

                        DateTime created_at = reader.GetDateTime(8);

                        int category_id = reader.GetInt32(9);

                        Stock stock = new Stock(id, brand, name, cost_price, selling_price, sku, quantity, variation, created_at, category_id);

                        Stocks.Add(stock);

                    }
                }
                reader.Close();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            return Stocks;
        }
        public Stock FindStock(int id)
        {
            Stock stock = null;
            try
            {
                conn.Open();

                string stockQuery = "SELECT id, brand, name, cost_price, selling_price, sku, quantity, variation, created_at, category_id from stocks where id = '" + id + "'";

                MySqlCommand command = new MySqlCommand(stockQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    {
                        string brand = reader.GetString(1);

                        string name = reader.GetString(2);

                        double cost_price = reader.GetDouble(3);

                        double selling_price = reader.GetDouble(4);

                        string sku = reader.GetString(5);

                        int quantity = reader.GetInt32(6);

                        string variation = reader.GetString(7);

                        DateTime created_at = reader.GetDateTime(8);

                        int category_id = reader.GetInt32(9);

                        stock = new Stock(id, brand, name, cost_price, selling_price, sku, quantity, variation, created_at, category_id);
                    }
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            return stock;
        }
        public bool AddStock(int id, string brand, string name, double costPrice, double sellingPrice, string sKU, int quantity, string variation, DateTime created_at, int category_Id)
        {
            try
            {
                conn.Open();
                string addstockQuery = "Insert into stocks (id, brand, name, cost_price, selling_price, sku, quantity, variation, created_at, category_id)values ('" + id + "', '" + brand + "','" + name + "', '" + costPrice + "', '" + sellingPrice + "', '" + sKU + "', '" + quantity + "', '" + variation + "', '" + created_at.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + category_Id + "')";

                MySqlCommand command = new MySqlCommand(addstockQuery, conn);
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
        public bool UpdateStock(int id, string brand, string name, double costPrice, double sellingPrice, string sKU, int quantity, string variation)
        {
            var stock = FindStock(id);
            try
            {
                conn.Open();

                string updatestockQuery = "update stocks set brand ='" + brand + "',name ='" + name + "', cost_price = '" + costPrice + "', selling_price = '" + sellingPrice + "', sku = '" + sKU + "', quantity = '" + quantity + "', variation = '" + variation + "' where id = '" + id + "' ";

                MySqlCommand command = new MySqlCommand(updatestockQuery, conn);
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
            var stock = FindStock(id);
            try
            {
                conn.Open();
                string deleteStockQuery = "delete from stocks where id = '" + id + "'";

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
    }
}


