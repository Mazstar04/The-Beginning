using StockAppEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAppEF.Repositories
{
    public class StockRepository : IStockRepository
    {
        private readonly StockDbContext _dbContext;

        public StockRepository(StockDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Stock AddStock(Stock stock)
        {
            _dbContext.Stocks.Add(stock);
            _dbContext.SaveChanges();
            return stock;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Stock FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Stock> GetStocks()
        {
            throw new NotImplementedException();
        }

        public Stock UpdateStock(Stock stock)
        {
            throw new NotImplementedException();
        }
    }
}
