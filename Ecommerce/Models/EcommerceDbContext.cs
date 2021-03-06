using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class EcommerceDbContext : IdentityDbContext<ApplicationUser>
    {

        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options)
        {

        }


        public DbSet<Product> products { get; set; }

        public DbSet<Category> categories { get; set; }

       public DbSet<Order> orders { get; set; }
    }
}
