using Integrator.Common;
using Integrator.Models.Domain.Authentication;
using Integrator.Models.Domain.Companies;
using Integrator.Models.ViewModels.Users;
using Integrator.Services.Companies;
using Microsoft.AspNetCore.Identity;
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
    public partial class UserRegistrationService : IUserRegistrationService
    {

        #region Fields
        private readonly IUserService _userService;
        private readonly ICompanyService _companyService;

        #endregion

        #region Ctor

        public UserRegistrationService(IUserService userService,
            ICompanyService companyService)
        {
            this._userService = userService;
            this._companyService = companyService;
        }

        #endregion
        //_customerService
        public UserRegistrationResult RegisterUser(RegisterViewModel request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));



            var result = new UserRegistrationResult();


            if (!CommonHelper.IsValidEmail(request.UserEmail))
            {
                result.AddError("Wrong Email Format.");
                return result;
            }

            if (string.IsNullOrWhiteSpace(request.UserPassword))
            {
                result.AddError("Password not correct or not provided.");
                return result;
            }

            //validate unique user
            if (_userService.GetUserByEmailAsync(request.UserEmail) == null)
            {
                result.AddError("Email Already Exists.");

                return result;
            }


            //at this point request is valid and can try create user
            IntegratorUser NewUser = new IntegratorUser()
            {
                Email = request.UserEmail,
                UserName = request.UserEmail,
                LastName = request.LastName,
                FirstName = request.FirstName
            };
            IdentityResult IsUserCreated = _userService.InsertUserAsync(NewUser, request.UserPassword).Result;
            if (!IsUserCreated.Succeeded)
            {
                result.AddError(IsUserCreated.Errors.ToString());

                return result;
            }
            else
            {
                result.NewlyRegistredUser = NewUser;
                //if user is created link the role that the user has been assigned.
                _userService.InsertUserRoleAsync(request.UserRole, request.UserEmail);

                if (request.UserRole.Equals("Company"))
                {
                    _companyService.AddCompanyRepresentitive(new CompanyRepresentative()
                    {
                        IntegratorUserID = result.NewlyRegistredUser.Id,
                        CompanyID = Convert.ToInt32(request.CompanyID)

                    });
                }
            }

            return result;
        }
    }
}
