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
using Integrator.Models.Domain.Files;

namespace Integrator.Services.Users
{
    public partial class UserService : IUserService
    {
        #region Fields

        private readonly IServiceProvider _serviceProvider;
        private readonly UserManager<IntegratorUser> _userManager;
        private readonly RoleManager<IntegratorRole> _roleManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IRepository<UserQualification> _userQualificationsRepository;
        private readonly IRepository<IntegratorUserLanguages> _userLanguagesRepository;
        private readonly IRepository<IntegratorUserInterest> _userInterestsRepository;
        private readonly IRepository<IntegratorUserAwards> _userAwardsRepository;
        private readonly IRepository<IntegratorUserContactDetail> _userContactDetailsRepository;
        private readonly IRepository<IntegratorFile> _commonIntegratorFileRepository;
        private readonly IRepository<UserPicture> _userProfilePictureRepository;
        private readonly IEntityCRUDResponse _entityCRUDResponse;




        #endregion
        public UserService(
            IServiceProvider serviceProvider,
            UserManager<IntegratorUser> userManager,
            RoleManager<IntegratorRole> roleManager,
            IHttpContextAccessor httpContextAccessor,
            IRepository<UserQualification> userQualificationsRepository,
            IRepository<IntegratorUserLanguages> userLanguagesRepository,
            IRepository<IntegratorUserInterest> userInterestsRepository,
            IRepository<IntegratorUserAwards> userAwardsRepository,
            IRepository<IntegratorUserContactDetail> userContactDetailsRepository,
            IRepository<IntegratorFile> commonIntegratorFileRepository,
            IRepository<UserPicture> userProfilePictureRepository,
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
            this._commonIntegratorFileRepository = commonIntegratorFileRepository;
            this._userProfilePictureRepository = userProfilePictureRepository;
        }

        //private > SetCurrentlyLoggedInUser()
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
            ////    var _userManager = serviceScope.ServiceProvider.GetService<UserManager<IntegratorUser>();

            ////    user =  _userManager.GetRoles();

            ////}

            ////using (var serviceScope = _serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            ////{
            ////    var _userManager = serviceScope.ServiceProvider.GetService<UserManager<IntegratorUser>();
            ////    _userManager.GetRoles()
            ////};
            return await _userManager.GetRolesAsync((IntegratorUser)_httpContextAccessor.HttpContext.User.Identity);

        }

        public async Task<IList<IntegratorUser>> GetAllUsersByRole(
            string roleName
           )
        {
            var ListOfUsers = await _userManager.GetUsersInRoleAsync(roleName);

            return ListOfUsers;
        }



        public string GetCurrentPassword(int userId)
        {

            //using (var serviceScope = _serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            //{
            //    var _userManager = serviceScope.ServiceProvider.GetService<UserManager<IntegratorUser>();

            //    // user =  _userManager.FindByEmail(email.ToUpper());

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
            //_userManager.GetUser()
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
            return CreatedSuccessfully;// _userManager.Create(NewUser, password); ;
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
                await _userManager.AddToRoleAsync(await _userManager.FindByEmailAsync(userNameAsEmailAddress), role);
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
        public IEntityCRUDResponse AddUserAward(IntegratorUserAwards entity)
        {
            try
            {
                _userAwardsRepository.Insert(entity);
                _entityCRUDResponse.Returned_ID = entity.Id;
                _entityCRUDResponse.Success = true;
                _entityCRUDResponse.Message = "Your Award was Successfully Added.";
            }
            catch (Exception e)
            {
                _entityCRUDResponse.Returned_ID = 0;
                _entityCRUDResponse.Success = false;
                _entityCRUDResponse.Message = "Your Award was NOT Successfully Added, - " + e.Message;
            }
            return _entityCRUDResponse;
        }

        public IEntityCRUDResponse DeleteUserAward(IntegratorUserAwards entity)
        {
            try
            {
                _userAwardsRepository.Delete(entity);
                _entityCRUDResponse.Returned_ID = entity.Id;
                _entityCRUDResponse.Success = true;
                _entityCRUDResponse.Message = "User Award was Successfully Deleted.";
            }
            catch (Exception e)
            {
                _entityCRUDResponse.Returned_ID = 0;
                _entityCRUDResponse.Success = false;
                _entityCRUDResponse.Message = "User Award was not successfully deleted, - " + e.Message;
            }
            return _entityCRUDResponse;
        }

        public List<IntegratorUserContactDetail> GetContactDetails()
        {
            var UserID = GetUserID();
            var query = from UCDR in _userContactDetailsRepository.Table
                        .Include(a => a.ContactDetail)
                        .Include(a => a.ContactDetail.ContactDetailType)
                        where UCDR.IntegratorUserID == UserID
                        select UCDR;

            return query.ToList();

        }

        public List<UserQualification> GetQualifications()
        {
            var UserID = GetUserID();
            var query = from UQR in _userQualificationsRepository.Table
                         .Include(a => a.EductaionalInstitution)
                         .Include(a => a.QualificationLevel)
                        where UQR.IntegratorUserID == UserID
                        select UQR;

            return query.ToList();
        }

        public List<IntegratorUserLanguages> GetUserLanguages()
        {
            var UserID = GetUserID();
            var query = from ULR in _userLanguagesRepository.Table
                        .Include(a => a.SpokenLanguage)
                        where ULR.IntegratorUserID == UserID
                        select ULR;

            return query.ToList();
        }

        public List<IntegratorUserInterest> GetUserInterests()
        {
            var UserID = GetUserID();
            var query = from ULR in _userInterestsRepository.Table
                        .Include(a => a.UserInterest)
                            // .Include(a=>a.InterestLevel)
                        where ULR.IntegratorUserID == UserID
                        select ULR;
            List<IntegratorUserInterest> ddddd = new List<IntegratorUserInterest>();
            try
            {
                ddddd = query.ToList();
            }
            catch (Exception e)
            {
                var xxxx = e.Message;
            }

            return ddddd;
        }
        #region Curriculum Vitae Components
        #region Insert Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual IEntityCRUDResponse AddUserLanguage(IntegratorUserLanguages entity)
        {
            try
            {

                if (entity.IsPrimaryLanguage)
                {
                    /*if the language to be added is set as the primary 
                    //language the get all othe assocciated languages and set them to false for the primary language
                    */
                    var ListOfAllUserLanguages = GetUserLanguages();
                    foreach (IntegratorUserLanguages item in ListOfAllUserLanguages)
                    {
                        item.IsPrimaryLanguage = false;
                    }
                    _userLanguagesRepository.Update(ListOfAllUserLanguages);
                }

                _userLanguagesRepository.Insert(entity);
                _entityCRUDResponse.Returned_ID = entity.Id;
                _entityCRUDResponse.Success = true;
                _entityCRUDResponse.Message = "Your Language was Successfully Added.";
            }
            catch (Exception e)
            {
                _entityCRUDResponse.Returned_ID = 0;
                _entityCRUDResponse.Success = false;
                _entityCRUDResponse.Message = "Your Interest was NOT Successfully Added, - " + e.Message;
            }
            return _entityCRUDResponse;
        }
        public virtual IEntityCRUDResponse DeleteUserLanguage(IntegratorUserLanguages entity)
        {
            try
            {
                //Gert Interest ID before deleting
                var UserLanguage = _userLanguagesRepository.GetById(entity.Id);
                var RTN_ID = UserLanguage.LanguageID;
                //Delete the Current USer Interest
                _userLanguagesRepository.Delete(UserLanguage);

                //Returns the ID if the Iterest Not the ID of The "UserInterestID"
                _entityCRUDResponse.Returned_ID = RTN_ID;
                _entityCRUDResponse.Success = true;
                _entityCRUDResponse.Message = "Your Language was Successfully Removed.";
            }
            catch (Exception e)
            {
                _entityCRUDResponse.Returned_ID = 0;
                _entityCRUDResponse.Success = false;
                _entityCRUDResponse.Message = "Your Interest was NOT Successfully Removed, - " + e.Message;
            }
            return _entityCRUDResponse;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual IEntityCRUDResponse AddUserInterest(IntegratorUserInterest entity)
        {
            try
            {
                _userInterestsRepository.Insert(entity);
                _entityCRUDResponse.Returned_ID = entity.Id;
                _entityCRUDResponse.Success = true;
                _entityCRUDResponse.Message = "Your Interest was Successfully Added.";
            }
            catch (Exception e)
            {
                _entityCRUDResponse.Returned_ID = 0;
                _entityCRUDResponse.Success = false;
                _entityCRUDResponse.Message = "Your Interest was NOT Successfully Added, - " + e.Message;
            }
            return _entityCRUDResponse;
        }

        public virtual IEntityCRUDResponse DeleteUserInterest(IntegratorUserInterest entity)
        {
            try
            {
                //Gert Interest ID before deleting
                var UserInterest = _userInterestsRepository.GetById(entity.Id);
                var RTN_ID = UserInterest.InterestID;
                //Delete the Current USer Interest
                _userInterestsRepository.Delete(UserInterest);

                //Returns the ID if the Iterest Not the ID of The "UserInterestID"
                _entityCRUDResponse.Returned_ID = RTN_ID;
                _entityCRUDResponse.Success = true;
                _entityCRUDResponse.Message = "Your Interest was Successfully Removed.";
            }
            catch (Exception e)
            {
                _entityCRUDResponse.Returned_ID = 0;
                _entityCRUDResponse.Success = false;
                _entityCRUDResponse.Message = "Your Interest was NOT Successfully Removed, - " + e.Message;
            }
            return _entityCRUDResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public IEntityCRUDResponse AddUserQualification(UserQualification entity)
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

        #region
        public IEntityCRUDResponse DeleteUserQualification(UserQualification entity)
        {
            try
            {
                _userQualificationsRepository.Delete(entity);
                _entityCRUDResponse.Returned_ID = entity.Id;
                _entityCRUDResponse.Success = true;
                _entityCRUDResponse.Message = "User Qualification was Successfully Deleted.";
            }
            catch (Exception e)
            {
                _entityCRUDResponse.Returned_ID = 0;
                _entityCRUDResponse.Success = false;
                _entityCRUDResponse.Message = "User Qualification was not successfully deleted, - " + e.Message;
            }
            return _entityCRUDResponse;
        }

        public IEntityCRUDResponse AddUserProfilePicture(IntegratorFile entity)
        {
            try
            {
                if (entity.UserPicture.IsCurrentProfilePicture)
                {
                    ResetAllUserPicturesAsNotDefault();
                }

                _commonIntegratorFileRepository.Insert(entity);
                _entityCRUDResponse.Returned_ID = entity.Id;
                _entityCRUDResponse.Success = true;
                _entityCRUDResponse.Message = "User Profile Picture was Successfully Added.";
            }
            catch (Exception e)
            {
                _entityCRUDResponse.Returned_ID = 0;
                _entityCRUDResponse.Success = false;
                _entityCRUDResponse.Message = "User Profile Picture was not successfully Added, - " + e.Message;
            }
            return _entityCRUDResponse;
        }
        public IEntityCRUDResponse SetUserProfilePictureAsDefault(int FileID)
        {
            try
            {

                //get user picture to update
                UserPicture UP = _userProfilePictureRepository.Table.Where(x => x.Id == FileID).FirstOrDefault();
                if (UP != null)
                {
                    ResetAllUserPicturesAsNotDefault();
                    UP.IsCurrentProfilePicture = true;


                    _userProfilePictureRepository.Update(UP);
                    _entityCRUDResponse.Returned_ID = UP.Id;
                    _entityCRUDResponse.Success = true;
                    _entityCRUDResponse.Message = "User Profile Picture was Successfully Updated.";
                }

            }
            catch (Exception e)
            {
                _entityCRUDResponse.Returned_ID = 0;
                _entityCRUDResponse.Success = false;
                _entityCRUDResponse.Message = "User Profile Picture was not successfully Updated, - " + e.Message;
            }
            return _entityCRUDResponse;
        }

        public async Task<byte[]> GetUserProfilePictureAsync()
        {
            var query = from a in _commonIntegratorFileRepository.Table
                .Include(x => x.InegratorFileBlob)
                .Include(x => x.UserPicture)
                        where a.UserPicture.IsCurrentProfilePicture == true && a.UserPicture.IntegratorUserID == GetUserID()
                        select a.InegratorFileBlob.FileBlob;

            return await query.FirstOrDefaultAsync();
        }

        public IEntityCRUDResponse DeleteUserProfilePicture(IntegratorFile entity)
        {
            try
            {
                _commonIntegratorFileRepository.Delete(entity);
                _entityCRUDResponse.Returned_ID = entity.Id;
                _entityCRUDResponse.Success = true;
                _entityCRUDResponse.Message = "User Profile Picture was Successfully Deleted.";
            }
            catch (Exception e)
            {
                _entityCRUDResponse.Returned_ID = 0;
                _entityCRUDResponse.Success = false;
                _entityCRUDResponse.Message = "User Profile Picture was not successfully deleted, - " + e.Message;
            }
            return _entityCRUDResponse;
        }


        #endregion
        #endregion

        #region Internal Function
        private void ResetAllUserPicturesAsNotDefault()
        {
            var query = _userProfilePictureRepository.Table
                .Where(x => x.IntegratorUserID == GetUserID());

            List<UserPicture> UP = query.ToList();
            foreach (var item in UP)
            {
                item.IsCurrentProfilePicture = false;
            }
            _userProfilePictureRepository.Update(UP);
        }
        #endregion



    }
}