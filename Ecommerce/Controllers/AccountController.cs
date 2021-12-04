using Ecommerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;

        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager , SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;


        }

        public IActionResult Index()
        {
            return View();
        }
        [Route("signup" , Name = "signuppage")]
        public ActionResult Signup()
        {


            return View();
        }
        [HttpPost]
        [Route("signup" ,Name ="signuppage")]
        public async Task<ActionResult> Signup(SignUpUserModel userModel)
        {

            if (ModelState.IsValid)
            {


                var user = new IdentityUser
                {
                    Email = userModel.Email,
                    UserName = userModel.Email,
                    
                };


                await _userManager.CreateAsync(user , userModel.Password);
               
            }
           


            return View();
        }

        //public ActionResult Login()
        //{
        //    return View();
        //}

       
        //[HttpPost]
        //public async Task<ActionResult> Login(LoginViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        var result = await _signInManager.PasswordSignInAsync(model.Email , model.Password ,false, false);



        //        if (result.Succeeded)
        //        {
        //            return RedirectToAction("display", "Product");
        //        }

                
        //    }

        //    return View(model);


           
        //}


    }
}
