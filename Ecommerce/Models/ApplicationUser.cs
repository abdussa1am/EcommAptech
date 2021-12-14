using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Fname { get; set; }
        public string Address { get; set; }

    }
}
