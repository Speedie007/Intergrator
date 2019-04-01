using Integrator.Models.ViewModels.CurriculumVitaes;
using Integrator.Models.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Factories.CurriculumVitae
{
    public partial interface ICurriculumVitaeViewModelFactory
    {
        CurriculumVitaeViewModel PerpareCurriculumVitaeViewModel(CurriculumVitaeViewModel model, Boolean DisplayFullCurriculumVitae);

        EditUserQualificationViewModel prepareEditCurriuclumVitaeQualifications();
    }
}
