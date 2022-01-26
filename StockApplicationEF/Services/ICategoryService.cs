using StockAppEF.Models;
using StockAppEF.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAppEF.Services
{
    public interface ICategoryService
    {
        public Category AddCategory(CreateCategoryViewModel model);
        public Category FindById(int id);
        public Category UpdateCategory(UpdateCategoryViewModel model);
        public void Delete(int id);
        public List<CategoryViewModel> GetCategories();
    }
}
