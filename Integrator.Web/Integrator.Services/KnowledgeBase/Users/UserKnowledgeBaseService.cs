using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integrator.Common;
using Integrator.Data.Interfaces;
using Integrator.Models.Domain.KnowledgeBase.Core;
using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using Microsoft.EntityFrameworkCore;

namespace Integrator.Services.KnowledgeBase.Users
{
    
    public partial class UserKnowledgeBaseService : IUserKnowledgeBaseService
    {
        #region Fields

        private readonly IRepository<UserJob> _userJobRepository;
        private readonly IRepository<UserJobRelatedIndustry> _userJobRelatedIndustryRepository;
        private readonly IRepository<UserJobSkill> _userJobSkillRepository;

        #endregion

        #region Ctor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userJobRepository"></param>
        /// <param name="userJobRelatedIndustryRepository"></param>
        /// <param name="userJobSkillRepository"></param>
        public UserKnowledgeBaseService(
            IRepository<UserJob> userJobRepository,
            IRepository<UserJobRelatedIndustry> userJobRelatedIndustryRepository,
            IRepository<UserJobSkill> userJobSkillRepository
            )
        {
            this._userJobRepository = userJobRepository;
            this._userJobRelatedIndustryRepository = userJobRelatedIndustryRepository;
            this._userJobSkillRepository = userJobSkillRepository;

        }

        public void AddUserJob(UserJob Entity)
        {
            throw new NotImplementedException();
        }

        public void AddUserJobRelatedIndusty(UserJobRelatedIndustry Entity)
        {
            throw new NotImplementedException();
        }

        public void AddUserJobSkills(UserJobSkill Entity)
        {
            throw new NotImplementedException();
        }

        public void GetUserJob(UserJob Entity)
        {
            throw new NotImplementedException();
        }

        public void GetUserJobByCurriculumVitae(int CurriculumVitaeID)
        {
            throw new NotImplementedException();
        }

        public void GetUserJobByCV(int CurriculumVitaeID)
        {
            throw new NotImplementedException();
        }

        public void GetUserJobByUser(int UserID)
        {
            throw new NotImplementedException();
        }

        public void GetUserJobRelatedIndusty(UserJobRelatedIndustry Entity)
        {
            throw new NotImplementedException();
        }

        public void GetUserJobSkills(UserJobSkill Entity)
        {
            throw new NotImplementedException();
        }

        public List<UserJob> ListUserJobByCurriculumVitae(int CurriculumVitaeID)
        {
            var query = _userJobRepository.TableNoTracking
                .Include(x => x.Company)
                .Include(x => x.CoreKbJob)
                .Include(x => x.UserJobSkills)
                .Where(x => x.CurriculumViteaID == CurriculumVitaeID);

            query = query.OrderByDescending(x => x.DateStarted).ThenByDescending(x => x.DateEnded);

            return  query.ToList();
        }

        public List<UserJob> ListUserJobByUser(int UserID)
        {
            throw new NotImplementedException();
        }

        public void RemoveUserJob(UserJob Entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveUserJobRelatedIndusty(UserJobRelatedIndustry Entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveUserJobSkills(UserJobSkill Entity)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Methods

        #region Select Section



        #endregion

        #region Insert Section




        #endregion

        #region Delete Section

        #endregion

        #endregion
    }
}
