using MySql.Data.MySqlClient;
using StockAppEF.Models;
using StockAppEF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAppWeb.Repositories
{

    public class CategoryRepository : ICategoryRepository
    {
        private readonly StockDbContext _dbContext;

        public CategoryRepository(StockDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Category AddCategory(Category category)
        {
             _dbContext.Categories.Add(category);
             _dbContext.SaveChanges();
             return category;
        }

        public Category FindById(int id)
        {
            return _dbContext.Categories.Find(id);
        }

        public Category UpdateCategory(Category category)
        {
                _dbContext.Categories.Update(category);
                _dbContext.SaveChanges();
                return category; 
        }

        public void Delete(int id)
        {
            var category = FindById(id);
            
            if (category != null)
            {
                _dbContext.Categories.Remove(category);
                _dbContext.SaveChanges();
            }
        }

        public List<Category> GetCategories()
        {
            return _dbContext.Categories.ToList();
        }
    }
}


