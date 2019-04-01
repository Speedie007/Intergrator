using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Integrator.Common.Interfaces;
using Integrator.Data.Interfaces;
using Integrator.Models.Domain.Authentication;
using Integrator.Models.Domain.CurriculumVitaes;
using Integrator.Models.ViewModels.Common;
using Integrator.Models.ViewModels.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Integrator.Models.Domain.Common;

namespace Integrator.Services.Users
{
    public partial class UserService : IUserService
    {
        #region Fields

        private readonly IServiceProvider _serviceProvider;
        private readonly UserManager<IntegratorUser> _userManager;
        private readonly RoleManager<IntegratorRole> _roleManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IRepository<UserQualifications> _userQualificationsRepository;
        private readonly IRepository<IntegratorUserLanguages> _userLanguagesRepository;
        private readonly IRepository<IntegratorUserInterest> _userInterestsRepository;
        private readonly IRepository<IntegratorUserAwards> _userAwardsRepository;
        private readonly IRepository<IntegratorUserContactDetails> _userContactDetailsRepository;
        private readonly IEntityCRUDResponse _entityCRUDResponse;




        #endregion
        public UserService(
            IServiceProvider serviceProvider,
            UserManager<IntegratorUser> userManager,
            RoleManager<IntegratorRole> roleManager,
            IHttpContextAccessor httpContextAccessor,
            IRepository<UserQualifications> userQualificationsRepository,
            IRepository<IntegratorUserLanguages> userLanguagesRepository,
            IRepository<IntegratorUserInterest> userInterestsRepository,
            IRepository<IntegratorUserAwards> userAwardsRepository,
            IRepository<IntegratorUserContactDetails> userContactDetailsRepository,
            IEntityCRUDResponse entityCRUDResponse
            )
        {
            this._userManager = userManager;
            this._roleManager = roleManager;
            this._httpContextAccessor = httpContextAccessor;
            this._serviceProvider = serviceProvider;
            this._userQualificationsRepository = userQualificationsRepository;
            this._userLanguagesRepository = userLanguagesRepository;
            this._userInterestsRepository = userInterestsRepository;
            this._userAwardsRepository = userAwardsRepository;
            this._userContactDetailsRepository = userContactDetailsRepository;
            this._entityCRUDResponse = entityCRUDResponse;
        }

        //private async Task SetCurrentlyLoggedInUserAsync()
        //{
        //    var CurrentUserLoggedIn = _userManager.get(_httpContextAccessor.HttpContext.User.Identity.Name);
        //    CurrentUserLoggedIn.
        //}

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

        public async Task<IList<string>> GetAllUserRolesAsync(bool showHidden = false)
        {
            ////using (var serviceScope = _serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            ////{
            ////    var _userManager = serviceScope.ServiceProvider.GetService<UserManager<IntegratorUser>>();

            ////    user = await _userManager.GetRolesAsync();

            ////}

            ////using (var serviceScope = _serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            ////{
            ////    var _userManager = serviceScope.ServiceProvider.GetService<UserManager<IntegratorUser>>();
            ////    _userManager.GetRolesAsync()
            ////};
            return await _userManager.GetRolesAsync((IntegratorUser)_httpContextAccessor.HttpContext.User.Identity);

        }

        public IPagedList<IntegratorUser> GetAllUsers(
            DateTime?
            createdFromUtc = null,
            DateTime? createdToUtc = null,
            int[] UserRoleIds = null,
            string email = null,
            string username = null,
            string firstName = null,
            string lastName = null,
            string phone = null,
            int pageIndex = 0, int pageSize = int.MaxValue, bool getOnlyTotalCount = false)
        {
            throw new NotImplementedException();
        }



        public string GetCurrentPassword(int userId)
        {

            //using (var serviceScope = _serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            //{
            //    var _userManager = serviceScope.ServiceProvider.GetService<UserManager<IntegratorUser>>();

            //    // user = await _userManager.FindByEmailAsync(email.ToUpper());

            //}
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



        public IntegratorUser GetUserById(int userId)
        {
            //_userManager.GetUserAsync()
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

        public int GetUserID()
        {
            int id = Convert.ToInt32(_userManager.GetUserId(_httpContextAccessor.HttpContext.User));
            return id;
        }

        public IntegratorUser GetCurrentLoginInUser()
        {
            var currentUser = _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User).Result;
            return currentUser;

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

        public async Task<IdentityResult> InsertUserAsync(IntegratorUser NewUser, string password)
        {
            IdentityResult CreatedSuccessfully;
            using (var serviceScope = _serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var _userManager = serviceScope.ServiceProvider.GetService<UserManager<IntegratorUser>>();
                var success = await _userManager.CreateAsync(NewUser, password);
                CreatedSuccessfully = success;
            }
            return CreatedSuccessfully;//await _userManager.CreateAsync(NewUser, password); ;
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

        public List<IntegratorUserAwards> GetAwards()
        {
            var UserID = GetUserID();
            var query = from UQR in _userAwardsRepository.Table
                        where UQR.IntegratorUserID == UserID
                        select UQR;

            return query.ToList();
        }

        public List<IntegratorUserContactDetails> GetContactDetails()
        {
            var UserID = GetUserID();
            var query = from UCDR in _userContactDetailsRepository.Table
                        .Include(a => a.ContactDetail)
                        .Include(a => a.ContactDetail.ContactDetailType)
                        where UCDR.IntegratorUserID == UserID
                        select UCDR;

            return query.ToList();

        }

        public List<UserQualifications> GetQualifications()
        {
            var UserID = GetUserID();
            var query = from UQR in _userQualificationsRepository.Table
                         .Include(a => a.EductaionalInstitution)
                         .Include(a => a.QualificationLevel)
                        where UQR.IntegratorUserID == UserID
                        select UQR;

            return query.ToList();
        }

        public List<IntegratorUserLanguages> GetLanguages()
        {
            var UserID = GetUserID();
            var query = from ULR in _userLanguagesRepository.Table
                        .Include(a => a.LanguageSpoken)
                        where ULR.IntegratorUserID == UserID
                        select ULR;

            return query.ToList();
        }

        public List<IntegratorUserInterest> GetInterests()
        {
            var UserID = GetUserID();
            var query = from ULR in _userInterestsRepository.Table
                        .Include(a => a.UserInterest)
                            // .Include(a=>a.InterestLevel)
                        where ULR.IntegratorUserID == UserID
                        select ULR;

            return query.ToList();
        }
        #region Curriculum Vitae Components
        #region Insert Methods
        public IEntityCRUDResponse AddUserQualification(UserQualifications entity)
        {
            try
            {
                _userQualificationsRepository.Insert(entity);
                _entityCRUDResponse.Returned_ID = entity.Id;
                _entityCRUDResponse.Success = true;
                _entityCRUDResponse.Message = "User Qualification was Successfully Added.";
            }
            catch (Exception e)
            {
                _entityCRUDResponse.Returned_ID = 0;
                _entityCRUDResponse.Success = false;
                _entityCRUDResponse.Message = "User Qualification was NOT Successfully Added, - " + e.Message;
            }
            return _entityCRUDResponse;
        }
        #endregion
        #endregion



    }
}