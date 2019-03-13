using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Integrator.Common.Interfaces;
using Integrator.Models.Domain.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Integrator.Services.Users
{
    public partial class UserService : IUserService
    {

        private readonly IServiceProvider _serviceProvider;

        public UserService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void DeleteUser(IntegratorUser user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserRole(IntegratorUserRole userRole)
        {
            throw new NotImplementedException();
        }

        public string FormatUserName(IntegratorUser user, bool stripTooLong = false, int maxLength = 0)
        {
            throw new NotImplementedException();
        }

        public IList<IntegratorUserRole> GetAllUserRoles(bool showHidden = false)
        {
            throw new NotImplementedException();
        }

        public IPagedList<IntegratorUser> GetAllUsers(DateTime? createdFromUtc = null, DateTime? createdToUtc = null, int[] UserRoleIds = null, string email = null, string username = null, string firstName = null, string lastName = null, string phone = null, int pageIndex = 0, int pageSize = int.MaxValue, bool getOnlyTotalCount = false)
        {
            throw new NotImplementedException();
        }

        public string GetCurrentPassword(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<IntegratorUser> GetUserByEmailAsync(string email)
        {
            IntegratorUser user;
            using (var serviceScope = _serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var _userManager = serviceScope.ServiceProvider.GetService<UserManager<IntegratorUser>>();

                user = await _userManager.FindByEmailAsync(email.ToUpper());

            }
            return user;
        }

        public IntegratorUser GetUserByGuid(Guid userGuid)
        {
            throw new NotImplementedException();
        }

        public IntegratorUser GetUserById(int userId)
        {
            throw new NotImplementedException();
        }

        public IntegratorUser GetUserBySystemName(string systemName)
        {
            throw new NotImplementedException();
        }

        public IntegratorUser GetUserByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public string GetUserFullName(IntegratorUser user)
        {
            throw new NotImplementedException();
        }

        public IList<string> GetUserPasswords(int? userId = null, int? passwordsToReturn = null)
        {
            throw new NotImplementedException();
        }

        public IntegratorUserRole GetUserRoleById(int userRoleId)
        {
            throw new NotImplementedException();
        }

        public IntegratorUserRole GetUserRoleBySystemName(string systemName)
        {
            throw new NotImplementedException();
        }

        public IList<IntegratorUser> GetUsersByIds(int[] userIds)
        {
            throw new NotImplementedException();
        }

        public async Task<IdentityResult> InsertUserAsync(IntegratorUser NewUser,string password)
        {
            IdentityResult CreatedSuccessfully;
            using (var serviceScope = _serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var _userManager = serviceScope.ServiceProvider.GetService<UserManager<IntegratorUser>>();
                var success = await _userManager.CreateAsync(NewUser, password);
                CreatedSuccessfully = success;
            }
            return CreatedSuccessfully;
        }

        public void InsertUserPassword(string userPassword)
        {
            throw new NotImplementedException();
        }

        public async Task InsertUserRoleAsync(string role, string userNameAsEmailAddress)
        {

            using (var serviceScope = _serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var _userManager = serviceScope.ServiceProvider.GetService<UserManager<IntegratorUser>>();
                await _userManager.AddToRoleAsync(await _userManager.FindByNameAsync(userNameAsEmailAddress), role);
            }

        }

        public bool IsPasswordRecoveryTokenValid(IntegratorUser user, string token)
        {
            throw new NotImplementedException();
        }

        public bool PasswordIsExpired(IntegratorUser user)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(IntegratorUser user)
        {
            throw new NotImplementedException();
        }

        public void UpdateUserPassword(string userPassword)
        {
            throw new NotImplementedException();
        }

        public void UpdateUserRole(IntegratorUserRole userRole)
        {
            throw new NotImplementedException();
        }
    }
}