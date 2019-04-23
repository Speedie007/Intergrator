using Integrator.Models.Domain.KnowledgeBase.Core;
using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Integrator.Services.KnowledgeBase.Users
{
    public partial interface IUserKnowledgeBaseService
    {

        #region Delete Section

        void RemoveUserJobRelatedIndusty(UserJobRelatedIndustry Entity);
        void RemoveUserJob(UserJob Entity);
        void RemoveUserJobSkills(UserJobSkill Entity);

        #endregion

        #region Select Section 

        void GetUserJobRelatedIndusty(UserJobRelatedIndustry Entity);
        void GetUserJobByCurriculumVitae(int CurriculumVitaeID);
        void GetUserJobByUser(int UserID);
        List<UserJob> ListUserJobByUser(int UserID);
        List<UserJob> ListUserJobByCurriculumVitae(int CurriculumVitaeID);
        void GetUserJobSkills(UserJobSkill Entity);
        #endregion

        #region Insert Section

        void AddUserJobRelatedIndusty(UserJobRelatedIndustry Entity);
        void AddUserJob(UserJob Entity);
        void AddUserJobSkills(UserJobSkill Entity);
        #endregion
    }
}
