using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.API.Models;

namespace Warehouse.API.Repositories
{
    public interface IWarehouseRepo 
    {
        IEnumerable<Product> GetProducts();

        Product GetProduct(int id);
    }
}
