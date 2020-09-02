using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.API.DTO_s
{
    public class ProductWriteDto
    {
        
        [Required]
        public string productName { get; set; }
        [Required]
        public string productCode { get; set; }
        [Required]
        public string releaseDate { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public double price { get; set; }
        [Required]
        public double starRating { get; set; }
        [Required]
        public string imageUrl { get; set; }
    }
}
