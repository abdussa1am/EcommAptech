using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class ProductController : Controller
    {

        private readonly EcommerceDbContext _db; 

        public ProductController(EcommerceDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult display()
        {

            var all = _db.products.ToList();

            return View(all);
        }

        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Product product)
        {

            _db.products.Add(product);
            _db.SaveChanges();
            return View();
        }


        public IActionResult delete(int id)
        {

            var deletedata = _db.products.Find(id);
            return View(deletedata);
        }
        [HttpPost]
        public IActionResult delete(Product product)
        {

            _db.products.Remove(product);
            _db.SaveChanges();
            return View();
        }
        public IActionResult details(int id)
        {

            var product_details = _db.products.Where(a => a.Id == id).FirstOrDefault();



            return View(product_details);
        }

        public IActionResult edit(int id)
        {
            var product_details = _db.products.Where(a => a.Id == id).FirstOrDefault();

            return View(product_details);
        }
        [HttpPost]
        public IActionResult edit(Product product)
        {

            _db.products.Update(product);
            _db.SaveChanges();
            return View();
        }


    }
}
