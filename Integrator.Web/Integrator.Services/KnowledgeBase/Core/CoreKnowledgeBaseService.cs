using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Integrator.Data.Interfaces;
using Integrator.Models.Domain.KnowledgeBase.Core;
using Microsoft.EntityFrameworkCore;
using Integrator.Common;

namespace Integrator.Services.KnowledgeBase.Core
{
    public partial class CoreKnowledgeBaseService : ICoreKnowledgeBaseService
    {

        #region Fields

        private readonly IRepository<CoreKBIndustryType> _coreIndustryRepository;
        private readonly IRepository<CoreKBIndustryCategory> _coreCategoryRepository;
        private readonly IRepository<CoreKBIndustryCategoryJob> _coreJobRepository;
        private readonly IRepository<CoreKBIndustryCategoryJobSkillSet> _coreSkillSetRepository;
        #endregion

        #region Cstor
        public CoreKnowledgeBaseService(
            IRepository<CoreKBIndustryType> CoreKBIndustryTypeRepository,
            IRepository<CoreKBIndustryCategory> CoreKBIndustryCategoryRepository,
            IRepository<CoreKBIndustryCategoryJob> CoreKBIndustryCategoryJobRepository,
            IRepository<CoreKBIndustryCategoryJobSkillSet> CoreKBIndustryCategoryJobSkillSetRepository
            )
        {
            this._coreIndustryRepository = CoreKBIndustryTypeRepository;
            this._coreCategoryRepository = CoreKBIndustryCategoryRepository;
            this._coreJobRepository = CoreKBIndustryCategoryJobRepository;
            this._coreSkillSetRepository = CoreKBIndustryCategoryJobSkillSetRepository;

        }
        #endregion

        #region Delete Section

        public bool DeleteCategories(List<CoreKBIndustryCategory> Categories)
        {
            try
            {
                _coreCategoryRepository.Delete(Categories);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool DeleteCategory(CoreKBIndustryCategory Category)
        {
            try
            {
                _coreCategoryRepository.Delete(Category);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool DeleteIndustries(List<CoreKBIndustryType> Industrires)
        {
            try
            {
                _coreIndustryRepository.Delete(Industrires);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool DeleteIndustry(CoreKBIndustryType Industry)
        {
            try
            {
                _coreIndustryRepository.Delete(Industry);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool DeleteJob(CoreKBIndustryCategoryJob Job)
        {
            try
            {
                _coreJobRepository.Delete(Job);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool DeleteJobs(List<CoreKBIndustryCategoryJob> Jobs)
        {
            try
            {
                _coreJobRepository.Delete(Jobs);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool DeleteSkillSet(CoreKBIndustryCategoryJobSkillSet SkillSet)
        {
            try
            {
                _coreSkillSetRepository.Delete(SkillSet);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool DeleteSkillSets(List<CoreKBIndustryCategoryJobSkillSet> SkillSets)
        {
            try
            {
                _coreSkillSetRepository.Delete(SkillSets);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }


        #endregion

        #region Select Section
        public CoreKBIndustryCategory GetCategory(int IndustryCategoryID)
        {
            var query = from a in _coreCategoryRepository.Table
                        where a.Id == IndustryCategoryID
                        select a;

            return query.FirstOrDefault();
        }

        public CoreKBIndustryType GetIndustry(int IndustryID)
        {
            var query = from a in _coreIndustryRepository.Table
                        where a.Id == IndustryID
                        select a;

            return query.FirstOrDefault();
        }

        public CoreKBIndustryCategoryJob GetJob(int CoreKBIndustryCategoryJobID)
        {
            var query = from a in _coreJobRepository.Table
                        where a.Id == CoreKBIndustryCategoryJobID
                        select a;

            return query.FirstOrDefault();
        }

        public CoreKBIndustryCategoryJobSkillSet GetSkillSet(int IndustryCategorySkillSetID)
        {
            var query = from a in _coreSkillSetRepository.Table
                        where a.Id == IndustryCategorySkillSetID
                        select a;

            return query.FirstOrDefault();
        }

        public List<CoreKBIndustryType> ListAllIndustries()
        {
            var query = from a in _coreIndustryRepository.Table
                        select a;

            return query.ToList();
        }

        public List<CoreKBIndustryCategory> ListCategoriesPerIndustry(int IndustryID)
        {
            var query = from a in _coreCategoryRepository.Table
                        where a.IndustryID == IndustryID
                        select a;

            return query.ToList();
        }

        public List<CoreKBIndustryCategoryJob> ListJobsPerCategory(int IndustryCategoryID)
        {
            var query = from a in _coreJobRepository.Table
                        where a.IndustryCategoryID == IndustryCategoryID
                        select a;

            return query.ToList();
        }

        public List<CoreKBIndustryCategoryJobSkillSet> ListSkillSetsPreJob(int IndustryCategoryJobID)
        {
            var query = from a in _coreSkillSetRepository.Table
                        where a.IndustryCategoryJobID == IndustryCategoryJobID
                        select a;

            return query.ToList();
        }
        #endregion


        #region Insert Section


        public bool InsertCategories(List<CoreKBIndustryCategory> Categories)
        {
            try
            {
                _coreCategoryRepository.Insert(Categories);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool InsertCategory(CoreKBIndustryCategory Category)
        {
            try
            {
                _coreCategoryRepository.Insert(Category);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool InsertIndustries(List<CoreKBIndustryType> Industries)
        {
            try
            {
                _coreIndustryRepository.Insert(Industries);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool InsertIndustry(CoreKBIndustryType Industry)
        {
            try
            {
                _coreIndustryRepository.Insert(Industry);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool InsertJob(CoreKBIndustryCategoryJob Job)
        {
            try
            {
                _coreJobRepository.Insert(Job);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool InsertJobs(List<CoreKBIndustryCategoryJob> Jobs)
        {
            try
            {
                _coreJobRepository.Insert(Jobs);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool InsertSkillSet(CoreKBIndustryCategoryJobSkillSet SkillSet)
        {
            try
            {
                _coreSkillSetRepository.Insert(SkillSet);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool InsertSkillSets(List<CoreKBIndustryCategoryJobSkillSet> SkillSets)
        {
            try
            {
                _coreSkillSetRepository.Insert(SkillSets);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

       

        #endregion

    }
}
