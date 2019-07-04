using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integrator.Models.Domain.Authentication;
using Integrator.Models.ViewModels.Users;
using Integrator.Services.Companies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.DependencyInjection;

namespace Integrator.Factories.Users
{
    public partial interface IUserViewModelFactory
    {
        /// <summary>
        /// Prepare the login model
        /// </summary>
        /// <returns>Login model</returns>
        LoginViewModel PrepareLoginModel();

        /// <summary>
        /// Prepare the Registration model
        /// </summary>
        /// <returns>Login model</returns>
        RegisterViewModel PrepareRegistrationLoginModel(string Role);
    }
    /// <summary>
    /// Represents the customer model factory
    /// </summary>
    public partial class UserViewModelFactory : IUserViewModelFactory
    {

        private readonly IServiceProvider _serviceProvider;
        private readonly ICompanyService _companyService;

        #region Ctor
        public UserViewModelFactory(IServiceProvider serviceProvider, ICompanyService companyService)
        {
            this._serviceProvider = serviceProvider;
            this._companyService = companyService;
        }
        #endregion

        #region User Login
        /// <summary>
        /// Prepare the login model
        /// </summary>
        /// <returns>Login model</returns>
        public virtual LoginViewModel PrepareLoginModel()
        {
            //Currently No Additional Configuring is required.
            var model = new LoginViewModel();
            return model;
        }

        public RegisterViewModel PrepareRegistrationLoginModel(string Role)
        {
            //Currently No Additional Configuring is required.
            var model = new RegisterViewModel();
            model.ListOfCompanies = (from a in this._companyService.ListCompanies()
                            select new SelectListItem()
                            {
                                 Text  = a.CompanyName,
                                  Value = a.Id.ToString()
                            }).ToList<SelectListItem>();
            model.UserRole = Role;
            //using (var serviceScope = _serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            //{
            //    var _roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IntegratorRole>>();
            //    var allUserRoles = _roleManager.Roles.ToList();
            //    foreach (IntegratorRole role in allUserRoles)
            //    {//UserRolesSelectItemViewModel
            //        model.UserRoles.Add(new SelectListItem()
            //        {
            //            Text = role.Name,
            //            Value = role.Name
            //        });
            //    }
            //}
            return model;
        }

        #endregion

        #region User Profile
        public UserProfileViewModel PrepareUserProfileViewModel(int UserID)
        {

            UserProfileViewModel model = new UserProfileViewModel();


            return model;
        }
        #endregion
    }
}
