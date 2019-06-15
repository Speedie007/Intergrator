using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integrator.Common;
using Integrator.Data.Interfaces;
using Integrator.Models.Domain.EnumClasses;
using Integrator.Models.Domain.KnowledgeBase.Core;
using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using Integrator.Models.ViewModels.Users;
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


        public UserJob GetUserJob(int UserJobID)
        {
            var query = _userJobRepository.Table.Where(x => x.Id == UserJobID);

            return query.FirstOrDefault();
        }

        public void GetUserJobByCurriculumVitae(int CurriculumVitaeID)
        {
            throw new NotImplementedException();
        }

        public void GetUserJobByCV(int CurriculumVitaeID)
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

        public List<UserSkillViewModel> ListUserHardSkillsPerUserJob(int _UserJobID)
        {
            return (from a in _userJobSkillRepository.Table
             .Include(x => x.CoreKbSkill)
             .Include(x => x.CoreKbSkill.CoreSkillCategory)
             .Include(x => x.CoreKbSkill.CoreSkillCategory.CoreKbSkillType)
                    where a.CoreKbSkill.CoreSkillCategory.CoreKbSkillType.Id == (int)EnumKbSkillType.HardSkill &&
                     a.UserJobID == _UserJobID
                    select
                     new UserSkillViewModel()
                     {
                         Id = a.CoreKbSkillID,
                         JobSkill = a.CoreKbSkill.CoreSkill,
                         SkillType = EnumKbSkillType.HardSkill,
                         SkillLevel = a.UserJobSkillLevel,
                         SkillCategoryName = a.CoreKbSkill.CoreSkillCategory.CoreSkillCategoryName,
                         SkillCategoryID = a.CoreKbSkill.CoreSkillCategoryID
                     }).ToList();
        }

        public List<UserIndustryViewModel> ListUserIndusrtyPerUserJob(int _UserJobID)
        {
            return (from a in _userJobRelatedIndustryRepository.Table
             .Include(x => x.CoreKbIndustry)
             .Include(x => x.CoreKbIndustry.CoreKbIndustryCategory)
                    where a.UserJobID == _UserJobID
                    select
                     new UserIndustryViewModel()
                     {
                         Id = a.CoreKbIndustryID,
                         JobIndustry = a.CoreKbIndustry.CoreKbIndustryName,
                         IndustryLevelInvolvement = a.LevelOfIndustryInvolvement,
                         IndustryCategoryName = a.CoreKbIndustry.CoreKbIndustryCategory.CoreKbIndustryCategoryName,
                         IndustryCategoryID = a.CoreKbIndustry.CoreKbIndustryCategoryID
                     }).ToList();
        }

        public List<UserJob> ListUserJobByCurriculumVitae(int CurriculumVitaeID)
        {
            var query = _userJobRepository.TableNoTracking
                .Include(x => x.Company)
                .Include(x => x.CoreKbJob)
                .Include(x => x.UserJobSkills)
                .Where(x => x.CurriculumViteaID == CurriculumVitaeID);

            query = query.OrderByDescending(x => x.DateStarted).ThenByDescending(x => x.DateEnded);

            return query.ToList();
        }

        public List<UserJob> ListUserJobByUser(int UserID)
        {
            throw new NotImplementedException();
        }

        public List<UserSkillViewModel> ListUserSoftSkillsPerUserJob(int _UserJobID)
        {
            return (from a in _userJobSkillRepository.Table
            .Include(x => x.CoreKbSkill)
            .Include(x => x.CoreKbSkill.CoreSkillCategory)
            .Include(x => x.CoreKbSkill.CoreSkillCategory.CoreKbSkillType)
                    where a.CoreKbSkill.CoreSkillCategory.CoreKbSkillType.Id == (int)EnumKbSkillType.SoftSkill &&
                     a.UserJobID == _UserJobID
                    select
                     new UserSkillViewModel()
                     {
                         Id = a.CoreKbSkillID,
                         JobSkill = a.CoreKbSkill.CoreSkill,
                         SkillType = EnumKbSkillType.SoftSkill,
                         SkillLevel = a.UserJobSkillLevel,
                         SkillCategoryName = a.CoreKbSkill.CoreSkillCategory.CoreSkillCategoryName,
                         SkillCategoryID = a.CoreKbSkill.CoreSkillCategoryID
                     }).ToList();
        }

        public void RemoveUserJob(int UserJobID)
        {
            var USerJobToDelete = _userJobRepository.GetById(UserJobID);

            try
            {
                if (USerJobToDelete != null)
                {
                    _userJobRepository.Delete(USerJobToDelete);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
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
