using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class SignUpUserModel
    {

        [Required]

        [DisplayName("Enter Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]

        [DataType(DataType.Password)]

        public string Password { get; set; }

        [Compare("Password" , ErrorMessage = "Password is not same")]
        [DataType(DataType.Password)]
        [Required]
        public string ConfirmPassword { get; set; }
    }
}
