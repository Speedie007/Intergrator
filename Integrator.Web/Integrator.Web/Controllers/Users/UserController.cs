using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Integrator.Factories.Users;
using Integrator.Models.Domain.Authentication;
using Integrator.Models.ViewModels.Users;
using Integrator.Web.Areas.Identity.Pages.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Integrator.Web.Controllers.Users
{
    public class UserController : Controller
    {
        #region Fields
        private readonly IUserViewModelFactory _userViewModelFactory;
        private readonly SignInManager<IntegratorUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        #endregion

        #region Ctor
        public UserController(
            IUserViewModelFactory userViewModelFactory,
            SignInManager<IntegratorUser> signInManager, 
            ILogger<LoginModel> logger
            )
        {
            this._userViewModelFactory = userViewModelFactory;
            this._signInManager = signInManager;
            this._logger = logger;
        }
        #endregion

        #region Login / logout
        [HttpGet]
        public virtual IActionResult Login()
        {
            var model = _userViewModelFactory.PrepareLoginModel();
            return View(model);
        }


        [HttpPost]
        public virtual IActionResult Login(LoginViewModel model  )
        {
            
            return View();
        }
        #endregion

        #region User Registration
        [HttpGet]
        public virtual IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public virtual IActionResult UserRegistration(RegisterViewModel model)
        {
            return View();
        }
        #endregion



    }
}