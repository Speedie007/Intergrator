using Integrator.Models.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Services.Users
{
    public interface IUserRegistrationService
    {

        /// <summary>
        /// Register User
        /// </summary>
        /// <param name="request">Request</param>
        /// <returns>Result</returns>
        UserRegistrationResult RegisterUser(RegisterViewModel request);
    }
}
