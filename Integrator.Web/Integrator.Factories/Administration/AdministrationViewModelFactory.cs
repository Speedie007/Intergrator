using System;
using System.Collections.Generic;
using System.Text;
using Integrator.Factories.Users;
using Integrator.Models.Domain.Authentication;
using Integrator.Models.ViewModels.Administration.Membership;
using Integrator.Services.Users;
using Microsoft.AspNetCore.Identity;

namespace Integrator.Factories.Administration
{
    public partial class AdministrationViewModelFactory : IAdministrationViewModelFactory
    {
        #region Fields

        private readonly IUserService _userService;


        #endregion

        #region Cstor
        public AdministrationViewModelFactory(

              IUserService userService
            )
        {
            this._userService = userService;
        }


        #endregion

        public SystemUserViewModel PrepareAdministrationSystemUserViewModel()
        {
            SystemUserViewModel model = new SystemUserViewModel();

            model.ListOfListSystemUsers.AddRange(_userService.GetAllUsersByRole("Individual").Result);
            model.ListOfAgents.AddRange(_userService.GetAllUsersByRole("Agent").Result);
            
            return model;
        }
    }
}
