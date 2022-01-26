using StockAppEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAppEF.Repositories
{
    public interface IStockRepository
    {
        public Stock AddStock(Stock stock);
        public Stock FindById(int id);
        public Stock UpdateStock(Stock stock);
        public void Delete(int id);
        public List<Stock> GetStocks();
    }
}
