using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;
using Warehouse.API.Models;

namespace Warehouse.API.Repositories
{
    public interface IWarehouseRepo 
    {
        bool saveChanges();
        IEnumerable<Product> GetProducts();

        Product GetProduct(int id);

        void PostProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(Product product);
    }
}
