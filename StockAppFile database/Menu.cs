using System;
using System.Collections.Generic;
using Entities;
using MySql.Data.MySqlClient;
using Repositories;

namespace FilePractical
{
    public class Menu
    {
        static string connectionString = "server=localhost;user=root;database=stockmanagement;port=3306;password=419300";
        static MySqlConnection conn = new MySqlConnection(connectionString);
        CategoryRepository categoryRepo = new CategoryRepository(conn);
        StockRepository stockRepo = new StockRepository(conn);
        private static void ShowMainMenu()
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Stock");
            Console.WriteLine("2. Category");
            Console.Write("Option: ");
        }
        private void CategoryMenu()
        {
            Console.WriteLine("0. Back");
            Console.WriteLine("1. Add Category");
            Console.WriteLine("2. List all Categories");
            Console.WriteLine("3. Update Category");
            Console.WriteLine("4. Delete Category");
            Console.WriteLine("5. Find Category by Id");
        }
        private void StockMenu()
        {
            Console.WriteLine("0. Back");
            Console.WriteLine("1. Add Stock");
            Console.WriteLine("2. List all Stock");
            Console.WriteLine("3. Update Stock");
            Console.WriteLine("4. Delete Stock");
            Console.WriteLine("5. Find Stock by Id");
        }
        public void MainMenu()
        {
            bool appRunning = true;

            do
            {
                ShowMainMenu();
                string option = Console.ReadLine().Trim();

                switch (option)
                {
                    case "0":
                        appRunning = false;
                        break;
                    case "1":
                        ShowStockMenu();
                        break;
                    case "2":
                        ShowCategoryMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid Option!");
                        break;

                }
            } while (appRunning);
        }
        private void AddCategoryDetails()
        {
            Console.Write("Enter Category Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Category Name: ");
            string name = Console.ReadLine();

            DateTime created_at = DateTime.Now;
            categoryRepo.AddCategory(id, name, created_at);
        }
        private void AddStockDetails()
        {
            Console.Write("Stock ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Brand of Stock: ");
            string brand = Console.ReadLine();

            Console.Write("Name of Stock: ");
            string name = Console.ReadLine();

            Console.Write("Cost Price: ");
            double costPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Selling Price: ");
            double sellingPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("SKU: ");
            string sku = Console.ReadLine();

            Console.Write("Stock Quantity: ");
            double quantity = Convert.ToDouble(Console.ReadLine());

            Console.Write("Stock Variation: ");
            string variation = Console.ReadLine();

            ReshuffleMenu();
            Console.Write("Choose Category: ");
            int category_Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            // List<Stock> Stocks = stockRepo.ListAllStocks();
            // foreach (var stock in Stocks)
            // {
            //     stock.Category_Id = category_Id;
            // }
            stockRepo.AddStock(id, brand, name, costPrice, sellingPrice, sku, quantity, variation, category_Id);
        }
        private void UpdateCategory()
        {
            Console.Write("Enter Id of Category: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Update Category Name: ");
            string name = Console.ReadLine();
            categoryRepo.UpdateCategory(id, name);
        }
        private void UpdateStock()
        {
            Console.Write("Enter ID of the Stock you want to update : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Update Stock Brand: ");
            string brand = Console.ReadLine();

            Console.Write("Update Stock Name: ");
            string name = Console.ReadLine();

            Console.Write("Update Cost Price: ");
            double costPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Update Selling Price: ");
            double sellingPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Update SKU: ");
            string sku = Console.ReadLine();

            Console.Write("Update Stock Quantity: ");
            double quantity = Convert.ToDouble(Console.ReadLine());

            Console.Write("Update Stock Variation: ");
            string variation = Console.ReadLine();

            ReshuffleMenu();
            Console.Write("Update Stock Category: ");
            int category_Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            stockRepo.UpdateStock(id, brand, name, costPrice, sellingPrice, sku, quantity, variation, category_Id);
        }
        private void DeleteCategory()
        {
            Console.Write("Enter Id of Category you want to Delete: ");
            int id = int.Parse(Console.ReadLine());
            categoryRepo.DeleteCategory(id);
        }
        private void DeleteStock()
        {
            Console.Write("Enter Id of Stock you want to Delete: ");
            int id = int.Parse(Console.ReadLine());
            stockRepo.DeleteStock(id);
        }
        private void ShowCategoryMenu()
        {
            CategoryMenu();
            Console.Write("Option: ");
            string option = Console.ReadLine().Trim();

            switch (option)
            {
                case "0":
                    break;
                case "1":
                    AddCategoryDetails();
                    ShowCategoryMenu();
                    break;
                case "2":
                    categoryRepo.GetCategories();
                    ShowCategoryMenu();
                    break;
                case "3":
                    UpdateCategory();
                    ShowCategoryMenu();
                    break;
                case "4":
                    DeleteCategory();
                    ShowCategoryMenu();
                    break;
                case "5":
                    Console.Write("Enter Id of Category you want to Find: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    categoryRepo.FindCategory(id);
                    ShowCategoryMenu();
                    break;
                default:
                    Console.WriteLine("Invalid Option!");
                    break;
            }
        }
        private void ShowStockMenu()
        {
            StockMenu();
            Console.Write("Option: ");
            string option = Console.ReadLine().Trim();

            switch (option)
            {
                case "0":
                    break;
                case "1":
                    AddStockDetails();
                    ShowStockMenu();
                    break;
                case "2":
                    stockRepo.GetStocks();
                    ShowStockMenu();
                    break;
                case "3":
                    UpdateStock();
                    ShowStockMenu();
                    break;
                case "4":
                    DeleteStock();
                    ShowStockMenu();
                    break;
                case "5":
                    Console.Write("Enter Id of Stock you want to Find: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    if(stockRepo.FindStock(id) == null)
                    {
                        Console.WriteLine($"Stock with Id-{id} does not exist");                        
                    }
                    stockRepo.FindStock(id);
                    ShowStockMenu();
                    break;
                default:
                    Console.WriteLine("Invalid Option!");
                    ShowStockMenu();
                    break;
            }
        }
        private void ReshuffleMenu()
        {
            List<Category> printAllCategories = categoryRepo.ListAllCategories();
            foreach(var printlist in printAllCategories)
            {
                Console.WriteLine($"{printlist.Id}. {printlist.Name}");
            }
        }
    }
}