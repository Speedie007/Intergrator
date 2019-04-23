using Integrator.Common.Interfaces;
using Integrator.Models.Domain.Authentication;
using Integrator.Models.Domain.Common;
using Integrator.Models.Domain.CurriculumVitaes;
using Integrator.Models.Domain.Files;
using Integrator.Models.ViewModels.Common;
using Integrator.Models.ViewModels.Users;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Integrator.Services.Users
{
    public interface IUserService
    {

        #region Curriculum Vitae Compomnents

        #region Select Methods
        List<IntegratorUserAwards> GetAwards();

        List<IntegratorUserContactDetail> GetContactDetails();

        List<UserQualification> GetQualifications();

        List<IntegratorUserLanguages> GetUserLanguages();

        List<IntegratorUserInterest> GetUserInterests();

        Task<byte[]> GetUserProfilePictureAsync();
        #endregion

        #region Insert Methods
        IEntityCRUDResponse AddUserLanguage(IntegratorUserLanguages entity);
        IEntityCRUDResponse AddUserQualification(UserQualification entity);
        IEntityCRUDResponse AddUserInterest(IntegratorUserInterest entity);
        IEntityCRUDResponse AddUserAward(IntegratorUserAwards entity);
        IEntityCRUDResponse AddUserProfilePicture(IntegratorFile entity);
        #endregion

        #region DeleteMethods

        IEntityCRUDResponse DeleteUserLanguage(IntegratorUserLanguages entity);
        IEntityCRUDResponse DeleteUserQualification(UserQualification entity);
        IEntityCRUDResponse DeleteUserInterest(IntegratorUserInterest entity);
        IEntityCRUDResponse DeleteUserAward(IntegratorUserAwards entity);
        IEntityCRUDResponse DeleteUserProfilePicture(IntegratorFile entity);
        #endregion

        #region Update Methods
        IEntityCRUDResponse SetUserProfilePictureAsDefault(int FileID);
        #endregion
        #endregion


        #region User
        /// <summary
        /// Get All Users
        /// </summary
        /// <param name="createdFromUtc"</param
        /// <param name="createdToUtc"</param
        /// <param name="UserRoleIds"</param
        /// <param name="email"</param
        /// <param name="username"</param
        /// <param name="firstName"</param
        /// <param name="lastName"</param
        /// <param name="phone"</param
        /// <param name="pageIndex"</param
        /// <param name="pageSize"</param
        /// <param name="getOnlyTotalCount"</param
        /// <returns</returns
        Task<IList<IntegratorUser>> GetAllUsersByRole(string roleName);



        IntegratorUser GetCurrentLoginInUser();

        int GetUserID();
        /// <summary
        /// Delete a user
        /// </summary
        /// <param name="user"IntegratorUser</param
        void DeleteUser(IntegratorUser user);

        /// <summary
        /// Gets a user
        /// </summary
        /// <param name="userId"User identifier</param
        /// <returnsA user</returns
        IntegratorUser GetUserById(int userId);

        /// <summary
        /// Get users by identifiers
        /// </summary
        /// <param name="userIds"User identifiers</param
        /// <returnsUsers</returns
        IList<IntegratorUser> GetUsersByIds(int[] userIds);



        /// <summary
        /// Get user by email
        /// </summary
        /// <param name="email"Email</param
        /// <returnsUser</returns
        Task<IntegratorUser> GetUserByEmailAsync(string email);

        /// <summary
        /// Get user by system role
        /// </summary
        /// <param name="systemName"System name</param
        /// <returnsUser</returns
        IntegratorUser GetUserBySystemName(string systemName);

        /// <summary
        /// Get user by username
        /// </summary
        /// <param name="username"Username</param
        /// <returnsUser</returns
        IntegratorUser GetUserByUsername(string username);



        /// <summary
        /// Insert a user
        /// </summary
        /// <param name="user"User</param
        Task<IdentityResult> InsertUserAsync(IntegratorUser NewUser, string password);

        /// <summary
        /// Updates the user
        /// </summary
        /// <param name="user"IntegratorUser</param
        void UpdateUser(IntegratorUser user);

        /// <summary
        /// Get full name
        /// </summary
        /// <param name="user"User</param
        /// <returnsUser full name</returns
        string GetUserFullName(IntegratorUser user);

        /// <summary
        /// Formats the user name
        /// </summary
        /// <param name="user"Source</param
        /// <param name="stripTooLong"Strip too long user name</param
        /// <param name="maxLength"Maximum user name length</param
        /// <returnsFormatted text</returns
        string FormatUserName(IntegratorUser user, bool stripTooLong = false, int maxLength = 0);
        #endregion

        #region User roles

        /// <summary
        /// Delete a user role
        /// </summary
        /// <param name="userRole"User role</param
        void DeleteUserRole(IntegratorUserRole userRole);

        /// <summary
        /// Gets a user role
        /// </summary
        /// <param name="userRoleId"User role identifier</param
        /// <returnsUser role</returns
        IntegratorUserRole GetUserRoleById(int userRoleId);

        /// <summary
        /// Gets a user role
        /// </summary
        /// <param name="systemName"User role system name</param
        /// <returnsUser role</returns
        IntegratorUserRole GetUserRoleBySystemName(string systemName);

        /// <summary
        /// Gets all user roles
        /// </summary
        /// <param name="showHidden"A value indicating whether to show hidden records</param
        /// <returnsUser roles</returns
        Task<IList<string>> GetAllUserRolesAsync(bool showHidden = false);

        /// <summary
        /// Inserts a user role
        /// </summary
        /// <param name="userRole"User role</param
        Task InsertUserRoleAsync(string role, string userNameAsEmailAddress);

        /// <summary
        /// Updates the user role
        /// </summary
        /// <param name="userRole"User role</param
        void UpdateUserRole(IntegratorUserRole userRole);

        #endregion

        #region User passwords

        /// <summary
        /// Gets user passwords
        /// </summary
        /// <param name="userId"User identifier; pass null to load all records</param
        /// <param name="passwordFormat"Password format; pass null to load all records</param
        /// <param name="passwordsToReturn"Number of returning passwords; pass null to load all records</param
        /// <returnsList of user passwords</returns
        IList<string> GetUserPasswords(int? userId = null, int? passwordsToReturn = null);

        /// <summary
        /// Get current user password
        /// </summary
        /// <param name="userId"User identifier</param
        /// <returnsUser password</returns
        string GetCurrentPassword(int userId);

        /// <summary
        /// Insert a user password
        /// </summary
        /// <param name="userPassword"User password</param
        void InsertUserPassword(string userPassword);

        /// <summary
        /// Update a user password
        /// </summary
        /// <param name="userPassword"User password</param
        void UpdateUserPassword(string userPassword);

        /// <summary
        /// Check whether password recovery token is valid
        /// </summary
        /// <param name="user"User</param
        /// <param name="token"Token to validate</param
        /// <returnsResult</returns
        bool IsPasswordRecoveryTokenValid(IntegratorUser user, string token);



        /// <summary
        /// Check whether user password is expired 
        /// </summary
        /// <param name="user"User</param
        /// <returnsTrue if password is expired; otherwise false</returns
        bool PasswordIsExpired(IntegratorUser user);

        #endregion
    }
}
