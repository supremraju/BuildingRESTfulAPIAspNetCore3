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


        public void PostProduct(Product product)
        {
             _context.Products.Add(product);
           
        }

        public bool saveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateProduct(Product product)
        {
           // throw new NotImplementedException();
           
        }

        public void DeleteProduct(Product product)
        {
             _context.Products.Remove(product);
        }
    }
}
