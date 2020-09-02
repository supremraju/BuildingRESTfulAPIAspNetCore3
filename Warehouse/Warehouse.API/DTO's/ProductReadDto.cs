using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.API.Repositories;

namespace Warehouse.API.DTO_s
{
    public class ProductReadDto 
    {
        
        public int productId { get; set; }
       
        public string productName { get; set; }
       
        public string productCode { get; set; }
       
        public string description { get; set; }
    
        public double price { get; set; }
        
       
    }
}
