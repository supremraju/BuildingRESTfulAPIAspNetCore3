using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.API.Models
{
    public class Product
    {
        [Key]
        public int productId { get; set; }
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
