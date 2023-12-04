using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Database;
using WebApplication2.Models;

namespace WebApplication2.Repositories
{
    public class ProductRepository
    {
        private readonly WebApplication2Context _context;

        public ProductRepository(WebApplication2Context context)
        {
            _context = context;
        }

        public List<Product> GetProductsByTransactionCode(string transactionCode)
        {
            return  _context.Transactions
                .Where(t => t.code == transactionCode)
                .SelectMany(t => t.Products)
                .ToList();
        }
        
        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

   
    }
}