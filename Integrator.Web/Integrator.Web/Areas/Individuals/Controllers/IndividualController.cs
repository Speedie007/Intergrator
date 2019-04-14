using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Integrator.Factories.Users;
using Integrator.Models.Domain.Authentication;
using Integrator.Models.ViewModels.Common;
using Integrator.Models.ViewModels.CurriculumVitaes;
using Integrator.Models.ViewModels.Users;
using Integrator.Services.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Integrator.Web.Areas.Individuals.Controllers
{
    [Area("Individuals")]
    public class IndividualController : Controller
    {
        #region Fields
        private readonly IUserViewModelFactory _userViewModelFactory;
        private readonly IUserRegistrationService _userRegistrationService;
                private readonly SignInManager<IntegratorUser> _signInManager;
        #endregion

        #region Cstor
        public IndividualController(IUserViewModelFactory userViewModelFactory,
            IUserRegistrationService userRegistrationService,
            SignInManager<IntegratorUser> signInManager)
        {
            this._userViewModelFactory = userViewModelFactory;
            this._userRegistrationService = userRegistrationService;
            this._signInManager = signInManager;
        }
        #endregion
        [HttpGet]
        public IActionResult DashBoard()
        {
            return View();
        }


        #region Profile

        [HttpGet]
        public IActionResult Profile()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditProfile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditProfile(string x)
        {
            return View();
        }
        #endregion

        #region Registation
        [HttpGet]
        public IActionResult Register()
        {
            var model = _userViewModelFactory.PrepareRegistrationLoginModel();
            model.TermsAndConditions = false;
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public virtual async Task<IActionResult> Register(RegisterViewModel model)
        {
            RedirectToActionResult RedirectNextPage = RedirectToAction("Register", "Individual");
            if (ModelState.IsValid)
            {
                model.UserRole = "Individual";
                UserRegistrationResult Result = _userRegistrationService.RegisterUser(model);

                if (Result.Success)
                {
                    await _signInManager.SignInAsync(Result.NewlyRegistredUser, isPersistent: false);

                    RedirectNextPage = RedirectToUserPortalByRole(model.UserRole);
                }
            }
            return RedirectNextPage;
        }

        #endregion

        #region Controller Internal methods
        private RedirectToActionResult RedirectToUserPortalByRole(string role)
        {
            RedirectToActionResult RedirectNextPage;
            switch (role.ToLower())
            {
                case "administrator":
                    RedirectNextPage = RedirectToAction("Home", "Administration", new { area = "Adminitration" });
                    break;
                case "agent":
                    RedirectNextPage = RedirectToAction("Home", "Agent");
                    break;
                case "individual":
                    RedirectNextPage = RedirectToAction("DashBoard", "Individual", new { area = "Individuals" });
                    break;
                case "company":
                    RedirectNextPage = RedirectToAction("Home", "Company");
                    break;
                default:
                    RedirectNextPage = RedirectToAction("Register", "User");
                    break;
            }
            return RedirectNextPage;
        }
        #endregion
    }
}