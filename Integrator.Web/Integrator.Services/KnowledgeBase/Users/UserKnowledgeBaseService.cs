using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        private readonly IRepository<IntegratorUserIndustry> _integratorUserIndustryRepository;
        private readonly IRepository<IntegratorUserIndustryCategory> _integratorUserIndustryCategoryRepository;
        private readonly IRepository<IntegratorUserIndustryCategoryJob> _integratorUserIndustryCategoryJobRepository;
        private readonly IRepository<IntegratorUserIndustryCategoryJobSkillSet> _integratorUserIndustryCategoryJobSkillSetRepository;
        #endregion

        #region Ctor

        /// <summary>
        /// injects the required repository entities.
        /// </summary>
        /// <param name="IntegratorUserIndustryRepository"></param>
        /// <param name="IntegratorUserIndustryCategoryRepository"></param>
        /// <param name="IntegratorUserIndustryCategoryJobRepository"></param>
        /// <param name="IntegratorUserIndustryCategoryJobSkillSetRepositor"></param>
        public UserKnowledgeBaseService(
            IRepository<IntegratorUserIndustry> integratorUserIndustryRepository,
            IRepository<IntegratorUserIndustryCategory> integratorUserIndustryCategoryRepository,
            IRepository<IntegratorUserIndustryCategoryJob> integratorUserIndustryCategoryJobRepository,
            IRepository<IntegratorUserIndustryCategoryJobSkillSet> integratorUserIndustryCategoryJobSkillSetRepositor
            )
        {
            this._integratorUserIndustryRepository = integratorUserIndustryRepository;
            this._integratorUserIndustryCategoryRepository = integratorUserIndustryCategoryRepository;
            this._integratorUserIndustryCategoryJobRepository = integratorUserIndustryCategoryJobRepository;
            this._integratorUserIndustryCategoryJobSkillSetRepository = integratorUserIndustryCategoryJobSkillSetRepositor;
        }

        #endregion

        #region Methods

        #region Select Section
        /// <summary>
        /// Returns all industries that the user is associated with.
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public List<CoreKBIndustryType> ListAllIndustries(int UserID)
        {
            var query = (from a in _integratorUserIndustryRepository.Table
                       .Include(a => a.CoreKBIndustry)
                             //from b in a.CoreKBIndustry.Industry
                         where a.IntegratorUserID == UserID
                         select a);

            return query.Select(a => a.CoreKBIndustry).ToList();
        }

        /// <summary>
        /// Returns single Industry that is associated with the user.
        /// </summary>
        /// <param name="IntegratorUserIndustryID"></param>
        /// <returns></returns>
        public CoreKBIndustryType GetIndustry(int IntegratorUserIndustryID)
        {
            var query = (from a in _integratorUserIndustryRepository.Table
                       .Include(x => x.CoreKBIndustry)
                         where a.Id == IntegratorUserIndustryID
                         select a);

            return query.Select(a => a.CoreKBIndustry).FirstOrDefault();
        }

        public List<CoreKBIndustryCategory> ListAllCategoriesPreIndustry(int UserID, int IntegratorUserIndustryID)
        {
            var query = (from a in _integratorUserIndustryCategoryRepository.Table
                        .Include(a => a.CoreKBIndustryCategory)
                         where a.IntegratorUserID == UserID && a.IntegratorUserIndustryID == IntegratorUserIndustryID
                         select a);

            return query.Select(a => a.CoreKBIndustryCategory).ToList<CoreKBIndustryCategory>();
        }

        public CoreKBIndustryCategory GetCategory(int IntegratorUserIndustryCategoryID)
        {
            var query = (from a in _integratorUserIndustryCategoryRepository.Table
                      .Include(x => x.CoreKBIndustryCategory)
                         where a.Id == IntegratorUserIndustryCategoryID
                         select a);

            return query.Select(a => a.CoreKBIndustryCategory).FirstOrDefault();
        }

        public List<CoreKBIndustryCategoryJob> ListAllJobsPreCategory(int UserID, int IntegratorUserIndustryCategoryID)
        {
            var query = (from a in _integratorUserIndustryCategoryJobRepository.Table
                       .Include(a => a.CoreKBIndustryCategoryJob)
                         where a.IntegratorUserID == UserID && a.IntegratorUserIndustryCategoryID == IntegratorUserIndustryCategoryID
                         select a);

            return query.Select(a => a.CoreKBIndustryCategoryJob).ToList<CoreKBIndustryCategoryJob>();
        }

        public CoreKBIndustryCategoryJob GetJob(int IntegratorUserIndustryCategoryJobID)
        {
            var query = (from a in _integratorUserIndustryCategoryJobRepository.Table
                     .Include(x => x.CoreKBIndustryCategoryJob)
                         where a.Id == IntegratorUserIndustryCategoryJobID
                         select a);

            return query.Select(a => a.CoreKBIndustryCategoryJob).FirstOrDefault();
        }

        public List<CoreKBIndustryCategoryJobSkillSet> ListAllSkillSetsPreJob(int UserID, int IntegratorUserIndustryCategoryJobID)
        {
            var query = (from a in _integratorUserIndustryCategoryJobSkillSetRepository.Table
                       .Include(a => a.CoreKBIndustryCategoryJobSkillSet)
                         where a.IntegratorUserID == UserID && a.IntegratorUserIndustryCategoryJobID == IntegratorUserIndustryCategoryJobID
                         select a);

            return query.Select(a => a.CoreKBIndustryCategoryJobSkillSet).ToList<CoreKBIndustryCategoryJobSkillSet>();
        }


        public CoreKBIndustryCategoryJobSkillSet GetSkillSet(int IntegratorUserIndustryCategoryJobSkillSetID)
        {
            var query = (from a in _integratorUserIndustryCategoryJobSkillSetRepository.Table
                     .Include(x => x.CoreKBIndustryCategoryJobSkillSet)
                         where a.Id == IntegratorUserIndustryCategoryJobSkillSetID
                         select a);

            return query.Select(a => a.CoreKBIndustryCategoryJobSkillSet).FirstOrDefault();
        }


        #endregion

        #region Insert Section

        public bool InsertIndustry(IntegratorUserIndustry Item)
        {
            try
            {
                _integratorUserIndustryRepository.Insert(Item);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }

        }

        public bool InsertIndustries(List<IntegratorUserIndustry> Item)
        {
            try
            {
                _integratorUserIndustryRepository.Insert(Item);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool InsertCategory(IntegratorUserIndustryCategory Item)
        {
            try
            {
                _integratorUserIndustryCategoryRepository.Insert(Item);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool InsertCategories(List<IntegratorUserIndustryCategory> Item)
        {
            try
            {
                _integratorUserIndustryCategoryRepository.Insert(Item);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool InsertJob(IntegratorUserIndustryCategoryJob Item)
        {
            try
            {
                _integratorUserIndustryCategoryJobRepository.Insert(Item);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool InsertJobs(List<IntegratorUserIndustryCategoryJob> Item)
        {
            try
            {
                _integratorUserIndustryCategoryJobRepository.Insert(Item);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool InsertSkillSet(IntegratorUserIndustryCategoryJobSkillSet Item)
        {
            try
            {
                _integratorUserIndustryCategoryJobSkillSetRepository.Insert(Item);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool InsertSkillSets(List<IntegratorUserIndustryCategoryJobSkillSet> Item)
        {
            try
            {
                _integratorUserIndustryCategoryJobSkillSetRepository.Insert(Item);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }


        #endregion

        #region Delete Section
        public bool DeleteIndustry(IntegratorUserIndustry Item)
        {
            try
            {
                _integratorUserIndustryRepository.Delete(Item);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool DeleteIndustries(List<IntegratorUserIndustry> Item)
        {
            try
            {
                _integratorUserIndustryRepository.Delete(Item);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool DeleteCategory(IntegratorUserIndustryCategory Item)
        {
            try
            {
                _integratorUserIndustryCategoryRepository.Delete(Item);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool DeleteCategories(List<IntegratorUserIndustryCategory> Item)
        {
            try
            {
                _integratorUserIndustryCategoryRepository.Delete(Item);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool DeleteJob(IntegratorUserIndustryCategoryJob Item)
        {
            try
            {
                _integratorUserIndustryCategoryJobRepository.Delete(Item);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool DeleteJobs(List<IntegratorUserIndustryCategoryJob> Item)
        {
            try
            {
                _integratorUserIndustryCategoryJobRepository.Delete(Item);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool DeleteSkillSet(IntegratorUserIndustryCategoryJobSkillSet Item)
        {
            try
            {
                _integratorUserIndustryCategoryJobSkillSetRepository.Delete(Item);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }

        public bool DeleteSkillSets(List<IntegratorUserIndustryCategoryJobSkillSet> Item)
        {
            try
            {
                _integratorUserIndustryCategoryJobSkillSetRepository.Delete(Item);
                return true;
            }
            catch (IntegratorException e)
            {
                //throw new IntegratorException(e.Message);
                return false;
            }
        }
        #endregion

        #endregion
    }
}
