using Integrator.Models.Domain.Files;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Services.Common.Files
{
    public partial interface IFileService
    {
        Boolean AddUserProfilePicture(IntegratorFiles UserPicture);

        Boolean AddUserDocument(IntegratorFiles Document);

        IntegratorFiles GetUserPicure(int UserID);

        List<IntegratorFiles> ListUserFiles(int UserID);

    }
}
