using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.API.Models;

namespace Warehouse.API.Repositories
{
    public class SqlWarehouseRepo : IWarehouseRepo
    {
        private readonly WarehouseContext _context;

        public SqlWarehouseRepo(WarehouseContext context)
        {
            _context = context;
        }
        public Product GetProduct(int id)
        {
            return _context.Products.FirstOrDefault(p => p.productId == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }
    }
}
