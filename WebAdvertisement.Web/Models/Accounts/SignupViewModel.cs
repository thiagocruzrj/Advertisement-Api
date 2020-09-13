﻿using System.ComponentModel.DataAnnotations;

namespace WebAdvertisement.Web.Models.Accounts
{
    public class SignupViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(6, ErrorMessage = "Password must be at least 6 characters long!")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and confirm password do not match!")]
        public string ConfirmPassword { get; set; }
    }
}