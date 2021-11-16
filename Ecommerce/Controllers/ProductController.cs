﻿using Ecommerce.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class ProductController : Controller
    {

        private readonly EcommerceDbContext _db;

        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(EcommerceDbContext db , IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _webHostEnvironment = webHostEnvironment;
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

            if (product.p_image != null)
            {
                var folder = "images/";

                folder += Guid.NewGuid().ToString() + "_" + product.p_image.FileName;



                product.productimageurl = "/" + folder;


                var serverfolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);

                product.p_image.CopyToAsync(new FileStream(serverfolder, FileMode.Create));
            }
          


            _db.products.Add(
              
                new Product
                {
                    Name = product.Name,
                    Price = product.Price,
                    productimageurl = product.productimageurl,
                }
                );
            
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
            return RedirectToAction("display");
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
