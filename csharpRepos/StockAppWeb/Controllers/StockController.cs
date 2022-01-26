using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using StockAppWeb.Repositories;
using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

namespace StockApplication.Controllers
{
    public class StockController : Controller
    {
       
        static string connectionString = "server=localhost;user=root;database=stockmanagement;port=3306;password=419300";
        static MySqlConnection conn = new MySqlConnection(connectionString);

        StockRepository stockRepository = new StockRepository(conn);

        CategoryRepository categoryRepository = new CategoryRepository(conn);

        public IActionResult Index()
        {
            var stockList = stockRepository.ListAllStocks();

            return View(stockList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var category = categoryRepository.ListAllCategories();

            return View(category);
        }

        [HttpPost]

        public IActionResult Create(int id,string brand, string name, double costPrice, double sellingPrice, string sKU, int quantity, string variation, int category_Id)
        {
            DateTime created_at = DateTime.Now;
            stockRepository.AddStock(id, brand, name, costPrice, sellingPrice, sKU, quantity, variation, created_at, category_Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var stock = stockRepository.FindStock(id);
            if (stock == null)
            {
                return NotFound();
            }
            return View(stock);
        }

        public IActionResult Update(int id)

        {
            var stock = stockRepository.FindStock(id);
            if (stock == null)
            {
                return NotFound();
            }
            return View(stock);

        }
        [HttpPost]
        public IActionResult Update(int id, string brand, string name, double costPrice, double sellingPrice, string sKU, int quantity, string variation)
        {
            stockRepository.UpdateStock(id, brand, name, costPrice, sellingPrice, sKU, quantity, variation);
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            var stock = stockRepository.FindStock(id);
            if (stock == null)
            {
                return NotFound();
            }

            stockRepository.DeleteStock(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Expensive()
        {
            var expensiveList = stockRepository.ListExpensiveStocks();

            return View(expensiveList);
        }
    }
    
}
