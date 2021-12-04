using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        [NotMapped]
        public IFormFile p_image { get; set; }

        public string productimageurl { get; set; }


        public int CategoryId { get; set; }

        public Category category { get; set; }
    }
}
