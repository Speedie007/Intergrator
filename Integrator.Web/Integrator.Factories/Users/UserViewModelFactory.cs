using System;
using System.Collections.Generic;
using System.Text;
using Integrator.Models.ViewModels.Users;

namespace Integrator.Factories.Users
{
    /// <summary>
    /// Represents the customer model factory
    /// </summary>
    public partial class UserViewModelFactory : IUserViewModelFactory
    {

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
    }
}
