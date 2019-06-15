using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Integrator.Factories.Users;
using Integrator.Models.Domain.Authentication;
using Integrator.Models.ViewModels.Users;
using Integrator.Services.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Integrator.Web.Areas.Company.Controllers
{
    [Area("Company")]
    public class AuthenticationController : Controller
    {
        #region Fields
        private readonly IUserViewModelFactory _userViewModelFactory;
        private readonly IUserRegistrationService _userRegistrationService;
        private readonly SignInManager<IntegratorUser> _signInManager;
        #endregion

        #region Cstor
        public AuthenticationController(
            IUserViewModelFactory userViewModelFactory,
            IUserRegistrationService userRegistrationService,
            SignInManager<IntegratorUser> signInManager
            )
        {
            this._userViewModelFactory = userViewModelFactory;
            this._userRegistrationService = userRegistrationService;
            this._signInManager = signInManager;
        }
        #endregion
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public virtual async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {

                UserRegistrationResult Result = _userRegistrationService.RegisterUser(model);


                if (Result.Success)
                {
                    await _signInManager.SignInAsync(Result.NewlyRegistredUser, isPersistent: false);

                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    foreach (var item in Result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, item);
                    }

                }
            }
            return View();
        }
    }
}