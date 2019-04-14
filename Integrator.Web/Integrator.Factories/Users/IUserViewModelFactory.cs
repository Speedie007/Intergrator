using Integrator.Models.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Factories.Users
{
    /// <summary>
    /// Represents the interface of the user model factory
    /// </summary>
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
}
