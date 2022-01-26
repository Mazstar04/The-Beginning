using StockAppEF.Models;
using StockAppEF.Models.ViewModels;
using StockAppEF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAppEF.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public Category AddCategory(CreateCategoryViewModel model)
        {
            var category = new Category
            {
                Name = model.Name,
                CreatedAt = DateTime.Now
            };

            return _categoryRepository.AddCategory(category);
        }

        public void Delete(int id)
        {
            _categoryRepository.Delete(id);
        }

        public Category FindById(int id)
        {
            return _categoryRepository.FindById(id);
        }

        public List<CategoryViewModel> GetCategories()
        {
            var categories =  _categoryRepository.GetCategories().Select(c => new CategoryViewModel
            {
                Id = c.Id,
                Name = c.Name,
                CreatedAt = c.CreatedAt
            }).ToList();

            return categories;
        }

        public Category UpdateCategory(UpdateCategoryViewModel model)
        {
            var category = new Category
            {
                Name = model.Name
            };

            return _categoryRepository.UpdateCategory(category);
        }
    }
}
