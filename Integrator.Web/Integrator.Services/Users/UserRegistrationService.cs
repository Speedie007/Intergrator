﻿using Integrator.Common;
using Integrator.Models.Domain.Authentication;
using Integrator.Models.ViewModels.Users;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Services.Users
{
    public partial class UserRegistrationService : IUserRegistrationService
    {

        #region Fields
        private readonly IUserService _userService;

        #endregion

        #region Ctor

        public UserRegistrationService(IUserService userService)
        {
            this._userService = userService;
        }

        #endregion
        //_customerService
        public UserRegistrationResult RegisterUser(RegisterViewModel request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            //if (request.Customer == null)
            //    throw new ArgumentException("Can't load current customer");

            var result = new UserRegistrationResult();


            if (!CommonHelper.IsValidEmail(request.Email))
            {
                result.AddError("Wrong Email Format.");
                return result;
            }

            if (string.IsNullOrWhiteSpace(request.Password))
            {
                result.AddError("Password not correct or not provided.");
                return result;
            }

            //if (_customerSettings.UsernamesEnabled && string.IsNullOrEmpty(request.))
            //{
            //    result.AddError(_localizationService.GetResource("Account.Register.Errors.UsernameIsNotProvided"));
            //    return result;
            //}

            //if (_customerSettings.UsernamesEnabled && _customerService.GetCustomerByUsername(request.Username) != null)
            //{
            //    result.AddError(_localizationService.GetResource("Account.Register.Errors.UsernameAlreadyExists"));
            //    return result;
            //}

            //validate unique user
            if (_userService.GetUserByEmailAsync(request.Email) == null)
            {
                result.AddError("Email Already Exists.");

                return result;
            }


            //at this point request is valid and can try create user
            IntegratorUser NewUser = new IntegratorUser()
            {
                Email = request.Email,
                UserName = request.Email,
                LastName = request.LastName,
                FirstName = request.FirstName
            };
            IdentityResult IsUserCreated = _userService.InsertUserAsync(NewUser, request.Password).Result;
            if (!IsUserCreated.Succeeded)
            {
                result.AddError(IsUserCreated.Errors.ToString());

                return result;
            }
            else
            {
                result.NewlyRegistredUser = NewUser;
                //if user is created link the role that the user has been assigned.
                _userService.InsertUserRoleAsync(request.RoleDefault, request.Email);
            }

            return result;
        }
    }
}
