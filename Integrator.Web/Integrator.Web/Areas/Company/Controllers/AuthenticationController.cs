using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Integrator.Factories.Users;
using Integrator.Models.Domain.Authentication;
using Integrator.Models.ViewModels.Users;
using Integrator.Services.Companies;
using Integrator.Services.EmailSending;
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
        private readonly UserManager<IntegratorUser> _userManager;
        private readonly ICustomEmailSender _emailSender;
        #endregion

        #region Cstor
        public AuthenticationController(
            IUserViewModelFactory userViewModelFactory,
            IUserRegistrationService userRegistrationService,
             UserManager<IntegratorUser> userManager,
            SignInManager<IntegratorUser> signInManager,
            ICustomEmailSender emailSender
            )
        {
            this._userViewModelFactory = userViewModelFactory;
            this._userRegistrationService = userRegistrationService;
            this._signInManager = signInManager;
            this._userManager = userManager;
            this._emailSender = emailSender;
        }
        #endregion
        [HttpGet]
        public IActionResult Register()
        {
            var model = _userViewModelFactory.PrepareRegistrationLoginModel("Company");
            model.TermsAndConditions = false;
            return View(model);
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
                    //await _signInManager.SignInAsync(Result.NewlyRegistredUser, isPersistent: false);

                    //return RedirectToAction("Index", "Dashboard");
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(Result.NewlyRegistredUser);
                    var callbackUrl = Url.Action(
                         action: "RegistrationConfirmation",
                         controller: "Authentication",
                        values: new { userId = Result.NewlyRegistredUser.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(model.UserEmail, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");
                    model.RegistrationConfirmationSent = true;
                }
                else
                {
                    foreach (var item in Result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, item);
                    }

                }
            }
            return View(model);
        }
        public async Task<IActionResult> RegistrationConfirmation(string userId, string code)
        {
            var model = new RegistrationConfirmationViewModel();
            if (userId == null || code == null)
            {
                return RedirectToAction(
                     actionName: "Login",
                      controllerName: "Authentication"
                    );
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userId}'.");
            }

            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (!result.Succeeded)
            {
                //throw new InvalidOperationException($"Error confirming email for user with ID '{userId}':");
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                model.ShowInvalid = true;
            } 
            else
            {
                //Login User
                await _signInManager.SignInAsync(user: user, isPersistent: false);
            }

            return View(model);
        }
    }
}