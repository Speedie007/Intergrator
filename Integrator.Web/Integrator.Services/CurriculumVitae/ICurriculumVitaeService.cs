using Integrator.Models.Domain.CurriculumVitaes;
using Integrator.Models.ViewModels.Common;
using Integrator.Models.ViewModels.CurriculumVitaes;
using Integrator.Models.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Services.CurriculumVitae
{
    public partial interface ICurriculumVitaeService
    {
        #region Select Methods

        CurriculumVitea GetCurriculumVitea(int UserID);

        CurriculumViteaWorkExperiences GetWorkExperience(int WorkExperienceID);

        IList<CurriculumViteaWorkExperiences> ListWorkExperiences(int CurriculumViteaID);



        #endregion

        #region Insert Methods
        CurriculumVitea AddCurriculumVitea(CurriculumVitea NewCV);

        #endregion

        #region Update Methods
        Boolean UpdateUserCurriculumVitea(CurriculumVitea model);
        #endregion

    }
}
