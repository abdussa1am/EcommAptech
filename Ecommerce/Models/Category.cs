using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Category
    {

        public int Id { get; set; }

        public string CName { get; set; }

        public IEnumerable<Product> products { get; set; }

    }
}
