using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using StockApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockApplication.Controllers
{
    public class StockController : Controller
    {
        static string connectionString = "server=localhost;user=root;database=stockmanagement;port=3306;password=419300";
        static MySqlConnection conn = new MySqlConnection(connectionString);
        StockRepository stockRepo = new StockRepository(conn);
        public IActionResult Index()
        {
            var stockList = stockRepo.ListAllStocks();
            return View(stockList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(int id, string brand, string name, double costPrice, double sellingPrice, string sku, double quantity, string variation, int category_Id)
        {
            DateTime created_At = DateTime.Now;
            stockRepo.AddStock(id, brand, name, costPrice, sellingPrice, sku, quantity, variation, category_Id);
            //return View();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Find(int id)
        {
            var stock = stockRepo.FindStock(id);
            if (stock == null)
            {
                return NotFound();
            }
            return View(stock);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var stock = stockRepo.FindStock(id);
            if (stock == null)
            {
                return NotFound();
            }
            return View(stock);

        }
        [HttpPost]
        public IActionResult Update(int id, string brand, string name, double costPrice, double sellingPrice, string sku, double quantity, string variation, int category_Id)
        {
            stockRepo.UpdateStock(id, brand, name, costPrice, sellingPrice, sku, quantity, variation, category_Id);
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            var stock = stockRepo.FindStock(id);
            if (stock == null)
            {
                return NotFound();
            }
            stockRepo.DeleteStock(id);
            return RedirectToAction("Index");
        }

    }
}