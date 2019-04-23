using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Integrator.Data.Interfaces;
using Integrator.Models.Domain.KnowledgeBase.Core;
using Microsoft.EntityFrameworkCore;
using Integrator.Common;
using Microsoft.EntityFrameworkCore.Query;

namespace Integrator.Services.KnowledgeBase.Core
{
    public partial class CoreKnowledgeBaseService : ICoreKnowledgeBaseService
    {

        #region Fields
        private readonly IRepository<CoreKbSkill> _coreKbSkillRepository;
        private readonly IRepository<CoreKbSkillType> _coreKbSkillTypeRepository;
        private readonly IRepository<CoreSkillCategory> _coreKbSkillCategoryRepository;
        private readonly IRepository<CoreKbJobSkill> _coreKbJobSkillRepository;
        private readonly IRepository<CoreKbJob> _coreKbJobRepository;
        private readonly IRepository<CoreKbIndustryJob> _coreKbIndustryJobRepository;
        private readonly IRepository<CoreKbIndustry> _coreKbIndustryRepository;
        private readonly IRepository<CoreKbIndustryCategory> _coreKbIndustryCategoryRepository;
        #endregion

        #region Cstor
        public CoreKnowledgeBaseService(
            IRepository<CoreKbSkill> CoreKbSkillRepository,
            IRepository<CoreKbSkillType> coreKbSkillTypeRepository,
            IRepository<CoreSkillCategory> coreKbSkillCategoryRepository,
              IRepository<CoreKbJobSkill> coreKbJobSkillRepository,
              IRepository<CoreKbJob> coreKbJobRepository,
              IRepository<CoreKbIndustryJob> coreKbIndustryJobRepository,
              IRepository<CoreKbIndustry> coreKbIndustryRepository,
              IRepository<CoreKbIndustryCategory> coreKbIndustryCategoryRepository
            )
        {
            this._coreKbSkillRepository = CoreKbSkillRepository;
            this._coreKbSkillCategoryRepository = coreKbSkillCategoryRepository;
            this._coreKbSkillTypeRepository = coreKbSkillTypeRepository;
            this._coreKbJobSkillRepository = coreKbJobSkillRepository;
            this._coreKbJobRepository = coreKbJobRepository;
            this._coreKbIndustryJobRepository = coreKbIndustryJobRepository;
            this._coreKbIndustryRepository = coreKbIndustryRepository;
            this._coreKbIndustryCategoryRepository = coreKbIndustryCategoryRepository;
        }




        #endregion

        #region Insert Methods
        public void AddCategories(List<CoreKbIndustryCategory> EntityList)
        {
            throw new NotImplementedException();
        }

        public void AddIndusrtyCategory(CoreKbIndustryCategory Entity)
        {
            try
            {
                _coreKbIndustryCategoryRepository.Insert(Entity);

            }
            catch (Exception e)
            {
                throw new IntegratorException("Error Adding Category.", e.InnerException);
            }

        }

        public void AddIndustries(List<CoreKbIndustryCategory> EntityList)
        {
            throw new NotImplementedException();
        }

        public void AddIndustry(CoreKbIndustry Entity)
        {
            try
            {
                _coreKbIndustryRepository.Insert(Entity);

            }
            catch (Exception e)
            {
                throw new IntegratorException("Error Adding Industry.", e.InnerException);
            }


        }

        public void AddIndustryJob(CoreKbJob Entity)
        {
            throw new NotImplementedException();
        }

        public void AddIndustryJobs(List<CoreKbJob> Entity)
        {
            throw new NotImplementedException();
        }

        public void AddJob(CoreKbJob Entity)
        {
            throw new NotImplementedException();
        }

        public void AddJobs(List<CoreKbJob> Entity)
        {
            throw new NotImplementedException();
        }

        public void AddJobSkill(CoreKbJobSkill Entity)
        {
            throw new NotImplementedException();
        }

        public void AddJobSkills(List<CoreKbJobSkill> Entity)
        {
            throw new NotImplementedException();
        }

        public void AddSkill(CoreKbSkill Entity)
        {
            try
            {
                _coreKbSkillRepository.Insert(Entity);

            }
            catch (Exception e)
            {
                throw new IntegratorException("Error Adding Skill.", e.InnerException);
            }
        }

        public void AddSkillCategories(List<CoreSkillCategory> Entity)
        {
            throw new NotImplementedException();
        }

        public void AddSkillCategory(CoreSkillCategory Entity)
        {

            try
            {
                _coreKbSkillCategoryRepository.Insert(Entity);

            }
            catch (Exception e)
            {
                throw new IntegratorException("Error Adding Skill Caegory.", e.InnerException);
            }

        }

        public void AddSkills(List<CoreKbSkill> Entity)
        {
            try
            {
                _coreKbSkillRepository.Insert(Entity);

            }
            catch (Exception e)
            {
                throw new IntegratorException("Error Adding Skill.", e.InnerException);
            }

        }

        public void AddSkillType(CoreKbSkillType Entity)
        {
            throw new NotImplementedException();
        }

        public void AddSkillTypes(List<CoreKbSkillType> Entity)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Delete Section

        public bool DeleteCategories(List<CoreKbIndustryCategory> EntityList)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCategory(CoreKbIndustryCategory Entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteIndustries(List<CoreKbIndustryCategory> EntityList)
        {
            throw new NotImplementedException();
        }

        public bool DeleteIndustry(CoreKbIndustry Entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteIndustryJob(CoreKbJob Entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteIndustryJobs(List<CoreKbJob> Entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteJob(CoreKbJob Entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteJobs(List<CoreKbJob> Entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteJobSkill(CoreKbJobSkill Entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteJobSkills(List<CoreKbJobSkill> Entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSkill(CoreKbSkill Entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSkillCategory(CoreSkillCategory Entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSkills(List<CoreKbSkill> Entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSkillsCategory(List<CoreSkillCategory> Entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSkillType(CoreKbSkillType Entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSkillTypes(List<CoreKbSkillType> Entity)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Select Section
        public CoreKbIndustry GetIndustry(int ID)
        {
            var query = _coreKbIndustryRepository.Table.Where(x => x.Id == ID);
            return query.FirstOrDefault();
        }

        public CoreKbIndustryCategory GetIndustryCategory(int ID)
        {
            var query = _coreKbIndustryCategoryRepository.Table.Where(x => x.Id == ID);
            return query.FirstOrDefault();
        }

        public CoreKbIndustryJob GetIndustryJob(int ID)
        {
            var query = _coreKbIndustryJobRepository.Table.Where(x => x.Id == ID);
            return query.FirstOrDefault();
        }

        public CoreKbJob GetJob(int ID)
        {
            var query = _coreKbJobRepository.Table.Where(x => x.Id == ID);
            return query.FirstOrDefault();
        }

        public CoreKbJobSkill GetJobSkill(int ID)
        {
            var query = _coreKbJobSkillRepository.Table.Where(x => x.Id == ID);
            return query.FirstOrDefault();
        }

        public CoreKbSkill GetSkill(int ID)
        {
            var query = _coreKbSkillRepository.Table.Where(x => x.Id == ID);
            return query.FirstOrDefault();
        }

        public CoreSkillCategory GetSkillCategory(int ID)
        {
            var query = _coreKbSkillCategoryRepository.Table.Where(x => x.Id == ID);
            return query.FirstOrDefault();
        }

        public CoreKbSkillType GetSkillType(int ID)
        {
            var query = _coreKbSkillTypeRepository.Table.Where(x => x.Id == ID);
            return query.FirstOrDefault();
        }

        public List<CoreKbSkill> ListHardSkills()
        {
            var query = _coreKbSkillRepository.Table
                .Include(x => x.CoreSkillCategory)
                .Where(x => x.CoreSkillCategory.CoreKbSkillType.CoreKbSkillTypeName.Equals("Hard"));
            return query.ToList();
        }

        public List<CoreKbIndustry> ListIndustries()
        {
            var query = _coreKbIndustryRepository.Table;
            return query.ToList();
        }
        public List<CoreKbIndustry> ListIndustriesByCategory(int CategoryID)
        {
            var query = _coreKbIndustryRepository.Table.Where(x => x.CoreKbIndustryCategoryID == CategoryID);
            return query.ToList();
        }

        public List<CoreKbIndustryCategory> ListIndustryCategories()
        {
            var query = _coreKbIndustryCategoryRepository.Table;
            return query.ToList();
        }

        public List<CoreKbIndustryJob> ListIndustryJobs()
        {
            var query = _coreKbIndustryJobRepository.Table;
            return query.ToList();
        }

        public List<CoreKbJob> ListJobs()
        {
            var query = _coreKbJobRepository.Table;
            return query.ToList();
        }

        public List<CoreKbJobSkill> ListJobSkills(int JobID)
        {
            var query = _coreKbJobSkillRepository.Table
                .Include(x => x.CoreSkill)
                .Where(x => x.CoreKbJobID == JobID);
            return query.ToList();
        }

        public List<CoreSkillCategory> ListSkillCategoriesBySkillType(int SkillTypeID)
        {
            var query = _coreKbSkillCategoryRepository.Table.Where(x => x.CoreKbSkillTypeID == SkillTypeID);
            return query.ToList();
        }
        public List<CoreSkillCategory> ListSkillCategories()
        {
            var query = _coreKbSkillCategoryRepository.Table;
            return query.ToList();
        }

        public List<CoreKbJobSkill> ListSkillJobs(int SkillID)
        {
            var query = _coreKbJobSkillRepository.Table
                .Include(x => x.CoreJob)
                .Where(x => x.CoreKbSkillID == SkillID);
            return query.ToList();
        }

        /// <summary>
        /// Returns a list of skills, if no type is supplied then all skills are returned.
        /// </summary>
        /// <param name="SkillType"></param>
        /// <returns></returns>
        public List<CoreKbSkill> ListSkills()
        {

            var query = _coreKbSkillRepository.Table
                       .Include(x => x.CoreSkillCategory)
                       .Include(x => x.CoreSkillCategory.CoreKbSkillType);

            return query.ToList();

        }
        public List<CoreKbSkill> ListSkillsByCategory(int CategoryID)
        {
            var query = _coreKbSkillRepository.Table
                      .Include(x => x.CoreSkillCategory)
                      .Include(x => x.CoreSkillCategory.CoreKbSkillType)
                      .Where(x => x.CoreSkillCategoryID == CategoryID);

            return query.ToList();
        }

        public List<CoreKbSkillType> ListSkillTypes()
        {
            var query = _coreKbSkillTypeRepository.Table;
            return query.ToList();
        }

        public List<CoreKbSkill> ListSoftSkills()
        {
            var query = _coreKbSkillRepository.Table
            .Include(x => x.CoreSkillCategory)
            .Include(x => x.CoreSkillCategory.CoreKbSkillType)
            .Where(x => x.CoreSkillCategory.CoreKbSkillType.CoreKbSkillTypeName.Equals("Soft"));
            return query.ToList();
        }


        #endregion
    }
}
