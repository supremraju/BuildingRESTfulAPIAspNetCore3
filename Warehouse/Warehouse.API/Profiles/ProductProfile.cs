using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.API.DTO_s;
using Warehouse.API.Models;

namespace Warehouse.API.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductReadDto>();
            CreateMap<ProductWriteDto, Product>();
            CreateMap<ProductUpdateDto, Product>();
        }

    }
}
