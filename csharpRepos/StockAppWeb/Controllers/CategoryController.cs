using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using StockAppWeb.Repositories;
using System;

namespace StockApplication.Controllers
{
    public class CategoryController : Controller
    {
        static string connectionString = "server=localhost;user=root;database=stockmanagement;port=3306;password=419300";
        static MySqlConnection conn = new MySqlConnection(connectionString);

        CategoryRepository categoryRepo = new CategoryRepository(conn);

        public IActionResult Index()
        {
            var categoryList = categoryRepo.ListAllCategories();

            return View(categoryList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(int id, string name)
        {
            DateTime created_at = DateTime.Now;
            categoryRepo.AddCategory(id, name, created_at);
            //return View();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var category = categoryRepo.FindCategory(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        public IActionResult Update(int id)

        {
            var category = categoryRepo.FindCategory(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);

        }
        [HttpPost]
        public IActionResult Update(int id, string name)
        {
            categoryRepo.UpdateCategory(id, name);
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            var category = categoryRepo.FindCategory(id);
            if (category == null)
            {
                return NotFound();
            }
 
            categoryRepo.DeleteCategory(id);
            return RedirectToAction("Index");
        }

    }
}
