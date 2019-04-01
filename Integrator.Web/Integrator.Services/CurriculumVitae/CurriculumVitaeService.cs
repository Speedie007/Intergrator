using System;
using System.Collections.Generic;
using System.Text;
using Integrator.Data.Interfaces;
using Integrator.Models.Domain.CurriculumVitaes;
using Integrator.Models.ViewModels.CurriculumVitaes;
using Integrator.Models.ViewModels.Users;
using Integrator.Services.CurriculumVitae;
using Integrator.Services.Users;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Integrator.Services.CurriculumVitae
{
    public partial class CurriculumVitaeService : ICurriculumVitaeService
    {

        #region Fields
        private readonly IUserService _userService;
        private readonly IRepository<CurriculumVitea> _curriculumViteaRepository;
        private readonly IRepository<CurriculumViteaWorkExperiences> _curriculumViteaWorkExperienceRepository;

        #endregion

        #region Cstor
        public CurriculumVitaeService(
                   IUserService userService,
                   IRepository<CurriculumVitea> curriculumViteaRepository,
                   IRepository<CurriculumViteaWorkExperiences> curriculumViteaWorkExperienceRepository
                   )
        {
            this._userService = userService;
            this._curriculumViteaRepository = curriculumViteaRepository;
            this._curriculumViteaWorkExperienceRepository = curriculumViteaWorkExperienceRepository;
        }
        #endregion

        #region Select Methods
        public CurriculumVitea GetCurriculumVitea(int UserID)
        {

            var query = from CVR in _curriculumViteaRepository.Table
                        where CVR.IntegratorUserID == UserID
                        //.Include(a => a.CurriculumViteaWorkExperiences)
                        //.Include(a => a.CurriculumViteaWorkExperiences.Select(b => b.Company))
                        //.Include(a => a.CurriculumViteaWorkExperiences.Select(b => b.CurriculumViteaWorkExperienceSkillSets))
                        //.Include(a => a.CurriculumViteaWorkExperiences.Select(b => b.CurriculumVitaeWorkExperienceReferences))
                        //.Include(a => a.CurriculumViteaWorkExperiences.Select(b => b.CurriculumVitaeWorkExperienceReferences.Select(c=>c.))
                        select CVR;

            return query.FirstOrDefault();

        }

        public IList<CurriculumViteaWorkExperiences> ListWorkExperiences(int CurriculumViteaID)
        {
            var query = from CVWER in _curriculumViteaWorkExperienceRepository.Table
                        .Include(a => a.Company)
                        .Include(a => a.Job)
                            //from b in CVWER.CurriculumViteaWorkExperienceSkillSets

                            .Include(a => a.CurriculumViteaWorkExperienceSkillSets)
                        where CVWER.CurriculumViteaID == CurriculumViteaID
                        select CVWER;

            return query.ToList();
        }


        public CurriculumViteaWorkExperiences GetWorkExperience(int WorkExperienceID)
        {
            var query = from CVWER in _curriculumViteaWorkExperienceRepository.Table
                        where CVWER.Id == WorkExperienceID
                        select CVWER;

            return query.FirstOrDefault();
        }



        #endregion

        #region Insert Methods


        public CurriculumVitea AddCurriculumVitea(CurriculumVitea NewCV)
        {
            _curriculumViteaRepository.Insert(NewCV);

            return NewCV;
        }


        #endregion

        #region Update Methods

        public Boolean UpdateUserCurriculumVitea(CurriculumVitea model)
        {
            try
            {
                _curriculumViteaRepository.Update(model);
                return true;
            }
            catch (Exception e)
            {
                var x = e.Message;
                return false;
            }

        }
        #endregion
    }
}
