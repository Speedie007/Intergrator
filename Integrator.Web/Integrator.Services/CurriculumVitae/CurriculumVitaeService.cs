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
using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using System.Globalization;

namespace Integrator.Services.CurriculumVitae
{
    public partial class CurriculumVitaeService : ICurriculumVitaeService
    {

        #region Fields
        private readonly IUserService _userService;
        private readonly IRepository<CurriculumVitea> _curriculumViteaRepository;
        private readonly IRepository<UserJob> _userJobRepository;

        #endregion

        #region Cstor
        public CurriculumVitaeService(
                   IUserService userService,
                   IRepository<CurriculumVitea> curriculumViteaRepository,
                   IRepository<UserJob> userJobRepository
                   )
        {
            this._userService = userService;
            this._curriculumViteaRepository = curriculumViteaRepository;
            this._userJobRepository = userJobRepository;
        }
        #endregion

        #region Select Methods
        public CurriculumVitea GetCurriculumVitea(int UserID)
        {

            CurriculumVitea query = (from CVR in _curriculumViteaRepository.Table
                                     where CVR.IntegratorUserID == UserID

                                     select CVR).FirstOrDefault();
            //If User Currently Does not have a CV Generated - first create CV for the current user.
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            if (query == null)
            {
                query = new CurriculumVitea();
                query.CareerSummary = "<h1>{Welcome Please Update with your Career Summary}</h1>";
                query.DateLastUpdated = DateTime.Now;
                query.IntegratorUserID = _userService.GetUserID();

                 AddCurriculumVitea(query);

            }

            return query;

        }

        public IList<UserJob> ListUserJobs(int CurriculumViteaID)
        {
            var query = from UJR in _userJobRepository.Table
                        .Include(a => a.Company)

                        where UJR.CurriculumViteaID == CurriculumViteaID
                        select UJR;

            return query.ToList();
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

        public UserJob GetUserJob(int WorkExperienceID)
        {
            throw new NotImplementedException();
        }


        #endregion
    }
}
