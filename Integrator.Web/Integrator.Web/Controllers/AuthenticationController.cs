using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Integrator.Factories.Users;
using Integrator.Models.Domain.Authentication;
using Integrator.Models.ViewModels.Users;
using Integrator.Services.KnowledgeBase.Users;
using Integrator.Services.Users;
using Integrator.Web.Areas.Identity.Pages.Account;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Integrator.Web.Controllers
{
    public class AuthenticationController : Controller
    {
        #region Fields
        private readonly IUserViewModelFactory _userViewModelFactory;
        private readonly SignInManager<IntegratorUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly IUserRegistrationService _userRegistrationService;
        private readonly IServiceProvider _serviceProvider;
        private readonly UserManager<IntegratorUser> _userManager;
        private readonly RoleManager<IntegratorRole> _roleManager;
        private readonly IUserKnowledgeBaseService _userIndustryService;

        [TempData]
        public string ErrorMessage { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        // private Task<IntegratorUser> GetCurrentUserAsync() => _userManager.GetUserAsync(User);

        #endregion

        #region Ctor
        public AuthenticationController(
            IUserViewModelFactory userViewModelFactory,
            SignInManager<IntegratorUser> signInManager,
            ILogger<LoginModel> logger,
            IUserRegistrationService userRegistrationService,
            IServiceProvider serviceProvider,
            UserManager<IntegratorUser> userManager,
            RoleManager<IntegratorRole> roleManager,
            IUserKnowledgeBaseService userIndustryService
            )
        {
            this._roleManager = roleManager;
            this._userRegistrationService = userRegistrationService;
            this._userViewModelFactory = userViewModelFactory;
            this._signInManager = signInManager;
            this._logger = logger;
            this._serviceProvider = serviceProvider;
            this._userManager = userManager;
            this._userIndustryService = userIndustryService;
        }
        #endregion

        #region Login
        [Authorize]
        public virtual async Task<IActionResult> SelectCorrectPortalAsync()
        {

            var CurrentUserLoggedIn = await _userManager.GetUserAsync(User);
            ICollection<IntegratorRole> UserRoles = (from AllRoles in _roleManager.Roles
                                                     from b in AllRoles.UserRoles
                                                     where b.UserId == CurrentUserLoggedIn.Id
                                                     select AllRoles).ToList<IntegratorRole>();


            if (UserRoles.Count > 0)
            {
                if (UserRoles.Count == 1)
                {
                    //this is sbyte trhe default behaviour.
                    //automtically send the user to the correct portal that matches the role he is assigned
                    foreach (IntegratorRole userRole in UserRoles)
                    {
                        return RedirectToUserPortalByRole(userRole.Name);
                        //return RedirectToAction(RedirectToUserPortalByRole(userRole.Name).ActionName, RedirectToUserPortalByRole(userRole.Name).ControllerName);
                    }
                }
                else
                {
                    //redirect the current user to a selction page where he/she can select the profile that they would like to open.
                }
            }
            else
            {
                //user has no roles assigned do some about it... LOL
            }
            return RedirectToRoute("default");
        }


        [HttpGet]
        [AllowAnonymous]

        public virtual async Task<IActionResult> Login(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl = returnUrl ?? Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;

            var model = _userViewModelFactory.PrepareLoginModel();
            return View(model);
        }


        [HttpPost]
        [AllowAnonymous]
        public virtual async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            //returnUrl = returnUrl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {

                    _logger.LogInformation("User logged in.");
                    //get role that the user belongs to
                    var CurrentUserLoggedIn = await _userManager.FindByEmailAsync(model.Email);
                    if (returnUrl != null)
                    {
                        return LocalRedirect(returnUrl);
                    }

                    ICollection<IntegratorRole> UserRoles = (from AllRoles in _roleManager.Roles
                                                             from b in AllRoles.UserRoles
                                                             where b.UserId == CurrentUserLoggedIn.Id
                                                             select AllRoles).ToList<IntegratorRole>();

                    if (UserRoles.Count > 0)
                    {
                        if (UserRoles.Count == 1)
                        {
                            //this is sbyte trhe default behaviour.
                            //automtically send the user to the correct portal that matches the role he is assigned
                            foreach (IntegratorRole userRole in UserRoles)
                            {
                                return RedirectToUserPortalByRole(userRole.Name);
                            }
                        }
                        else
                        {
                            //redirect the current user to a selction page where he/she can select the profile that they would like to open.
                        }
                    }
                    else
                    {
                        //user has no roles assigned do some about it... LOL
                    }

                    //using (var serviceScope = _serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
                    //{
                    //    var _userManager = serviceScope.ServiceProvider.GetService<UserManager<IntegratorUser>>();
                    //    _userManager.GetRolesAsync()
                    //};


                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = "", RememberMe = model.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");

                }
            }

            return View();
        }
        #endregion

        #region Registration

        #endregion

        #region forgot password

        #endregion

        #region Logout
        [HttpGet]
        public virtual async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");

            return RedirectToAction("LandingPage", "Home");
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
                    RedirectNextPage = RedirectToAction("Index", "DashBoard", new { area = "Individuals" });
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