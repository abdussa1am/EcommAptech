using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class EcommerceDbContext : IdentityDbContext
    {

        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options)
        {

        }


        public DbSet<Product> products { get; set; }
    }
}
