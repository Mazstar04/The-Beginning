using Microsoft.AspNetCore.Mvc;
using StockAppEF.Models;
using StockAppEF.Models.ViewModels;
using StockAppEF.Repositories;
using StockAppEF.Services;
using StockAppWeb.Repositories;
using System.Threading.Tasks;

namespace StockAppEF.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var categories = _categoryService.GetCategories();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateCategoryViewModel model)
        {
            _categoryService.AddCategory(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var category = _categoryService.FindById(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }


        public IActionResult Update(int id)
        {
            var category = _categoryService.FindById(id);
            if (category == null)
            {
                return NotFound();
            }
            else
            {
                return View(category);
            }
        }

        [HttpPost]
        public IActionResult Update(UpdateCategoryViewModel model)
        {

            _categoryService.UpdateCategory(model);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var category = _categoryService.FindById(id);
            if (category == null)
            {
                return NotFound();
            }
            _categoryService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
