using Integrator.Models.ViewModels.ViewModelBaseComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Integrator.Models.ViewModels.Users
{
    public partial class LoginViewModel: BaseIntegratorViewModel
    {
        public bool CheckoutAsGuest { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required]
        public string Email { get; set; }

        public bool UsernamesEnabled { get; set; }
        [Display(Name = "User Name")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "User Password")]
        [Required]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }

        public bool DisplayCaptcha { get; set; }
    }
}