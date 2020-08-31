using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.API.Models;
using Warehouse.API.Repositories;

namespace Warehouse.API.Controllers
{
    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouseRepo _repository;

        public WarehouseController(IWarehouseRepo repository)
        {
            _repository = repository;
        }

        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            var productItems = _repository.GetProducts();

            return Ok(productItems);
        }

        public ActionResult<Product> GetProduct(int id)
        {
            var productItem = _repository.GetProduct(id);

            return Ok(productItem);

        }
        
    }
}
