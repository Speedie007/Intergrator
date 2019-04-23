using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Integrator.Factories.Administration;
using Integrator.Factories.Users;
using Integrator.Models.Domain.Authentication;
using Integrator.Models.ViewModels.Users;
using Integrator.Services.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Integrator.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class MemebersController : Controller
    {
        #region Fields
        private readonly IUserViewModelFactory _userViewModelFactory;
        private readonly IUserRegistrationService _userRegistrationService;
        private readonly SignInManager<IntegratorUser> _signInManager;
        private readonly IAdministrationViewModelFactory _administrationViewModelFactory;
        #endregion

        #region Cstor
        public MemebersController(
            IUserViewModelFactory userViewModelFactory,
             IAdministrationViewModelFactory administrationViewModelFactory,
              IUserRegistrationService userRegistrationService,
               SignInManager<IntegratorUser> signInManager
            )
        {
            this._userViewModelFactory = userViewModelFactory;
            this._administrationViewModelFactory = administrationViewModelFactory;
            this._userRegistrationService = userRegistrationService;
            this._signInManager = signInManager;
        }
        #endregion 

        public IActionResult Index()
        {
            var model = _administrationViewModelFactory.PrepareAdministrationSystemUserViewModel();
            return View(model);
        }

        public IActionResult Agents()
        {
            return View();
        }

        #region Registation
        [HttpGet]
        public IActionResult RegisterAgent()
        {
            var model = _userViewModelFactory.PrepareRegistrationLoginModel("Agent");
            model.TermsAndConditions = true;
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public virtual async Task<IActionResult> RegisterAgent(RegisterViewModel model)
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

        #endregion


    }
}