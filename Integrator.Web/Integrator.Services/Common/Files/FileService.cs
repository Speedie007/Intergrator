using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integrator.Common;
using Integrator.Data.Interfaces;
using Integrator.Models.Domain.Files;
using Integrator.Services.Users;
using Microsoft.EntityFrameworkCore;

namespace Integrator.Services.Common.Files
{
    public partial class FileService : IFileService
    {
        #region Fields

        private readonly IRepository<IntegratorFile> _integratorFilesRepository;
        private readonly IRepository<UserPicture> _userPicturesRepository;
        private readonly IUserService _userService;
        #endregion
        #region Cstor
        public FileService(
            IRepository<UserPicture> userPicturesRepository,
            IRepository<IntegratorFile> integratorFilesRepository,
            IUserService userService
            )
        {
            this._integratorFilesRepository = integratorFilesRepository;
            this._userService = userService;
            this._userPicturesRepository = userPicturesRepository;
        }
        #endregion
        public bool AddUserDocument(IntegratorFile Document)
        {
            throw new NotImplementedException();
        }

        public bool AddUserProfilePicture(IntegratorFile UserPicture)
        {
            try
            {
                _integratorFilesRepository.Insert(UserPicture);
                return true;
            }
            catch (IntegratorException e)
            {
                throw new IntegratorException(e.Message);

            }

        }

        public UserPicture GetUserPicure(int UserPictureID, Boolean IncludeBlob = false)
        {
            if (IncludeBlob)
            {
                var query = from a in _userPicturesRepository.Table
                     .Include(x => x.IntegratorFile)
                     .Include(x => x.IntegratorFile.InegratorFileBlob)
                            where a.Id == UserPictureID
                            select a;


                return query.FirstOrDefault();
            }
            else
            {
                var query = from a in _userPicturesRepository.Table
                     .Include(x => x.IntegratorFile)
                            where a.Id == UserPictureID
                            select a;


                return query.FirstOrDefault();
            }

        }

        public List<UserPicture> ListUserProfilePictures(Boolean IncludeBlob = false)
        {

            if (IncludeBlob)
            {
                var query = from a in _userPicturesRepository.Table
                       .Include(x => x.IntegratorFile)
                       .Include(x => x.IntegratorFile.InegratorFileBlob)
                            where a.IntegratorUserID == _userService.GetUserID()
                            select a;
                return query.ToList();
            }
            else
            {
                var query = from a in _userPicturesRepository.Table
                      .Include(x => x.IntegratorFile)
                            where a.IntegratorUserID == Convert.ToInt64(_userService.GetUserID())
                            select a;
                return query.ToList();
            }
        }


    }
}
