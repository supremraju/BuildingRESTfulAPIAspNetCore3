using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.API.DTO_s;
using Warehouse.API.Models;
using Warehouse.API.Repositories;

namespace Warehouse.API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouseRepo _repository;
        private readonly IMapper _mapper;

        public WarehouseController(IWarehouseRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<ProductReadDto> GetProducts()
        {
            var productItems = _repository.GetProducts();

            return Ok(_mapper.Map<IEnumerable<ProductReadDto>>(productItems));
        }

        [HttpGet("{productId}", Name="AddProduct")]
        public ActionResult<ProductReadDto> GetProduct(int id)
        {
            var productItem = _repository.GetProduct(id);

            return Ok(_mapper.Map<ProductReadDto>(productItem));

        }

        [HttpPost]
        public ActionResult<ProductReadDto> PostProduct(ProductWriteDto product)
        {

            var productModel = _mapper.Map<Product>(product);
            _repository.PostProduct(productModel);
            _repository.saveChanges();

           // var productReadDto = _mapper.Map<ProductReadDto>(productModel);

           // return CreatedAtRoute(nameof(GetProduct), new {id = productReadDto.productId}, productReadDto);

            //Getting 500 error : should look into status Codes code (201) again.

            return Ok(productModel);

        }

        [HttpPut]
        public ActionResult UpdateProduct (int id, ProductUpdateDto product)
        {
            var productUpdateDto = _repository.GetProduct(id);

            _mapper.Map(product, productUpdateDto);
            

            _repository.UpdateProduct(productUpdateDto);
            _repository.saveChanges();

            return NoContent();

        }

        [HttpDelete("{id}")]

        public ActionResult DeleteProduct(int id)
        {
            var deleteProduct = _repository.GetProduct(id);

            _repository.DeleteProduct(deleteProduct);

            _repository.saveChanges();

            return NoContent();
        }
        
    }
}
