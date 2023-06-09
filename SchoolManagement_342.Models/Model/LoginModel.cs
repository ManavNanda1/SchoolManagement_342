﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement_342.Models.Model
{
   public  class LoginModel
    {
        [Required(ErrorMessage = "User Email Need To Be Filled")]
        [EmailAddress(ErrorMessage = "Please Write Proper Email Address")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "Password Is Required")]
        [MinLength(9)]
        [MaxLength (15)]
        public string UserPassword { get; set; }
        
        [Required(ErrorMessage = "Confirm Password Is Required")]
        [Compare(nameof(UserPassword), ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string ConfirmPassword { get; set; }
    }
}
