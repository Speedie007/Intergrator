using Integrator.Models.Domain.Files;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Services.Common.Files
{
    public partial interface IFileService
    {
        Boolean AddUserProfilePicture(IntegratorFile UserPicture);

        Boolean AddUserDocument(IntegratorFile Document);

        UserPicture GetUserPicure(int UserPictureID, Boolean IncludeBlob = false);

        List<UserPicture> ListUserProfilePictures(Boolean IncludeBlob = false);



    }
}
