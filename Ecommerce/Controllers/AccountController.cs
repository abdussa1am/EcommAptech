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

        public AccountController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
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

            if (ModelState.IsValid == true)
            {


                var user = new IdentityUser 
                { 
                    Email = userModel.Email,
                    UserName = userModel.Email,
                
                };


                await _userManager.CreateAsync(user);

            }


            return View();
        }



    }
}
