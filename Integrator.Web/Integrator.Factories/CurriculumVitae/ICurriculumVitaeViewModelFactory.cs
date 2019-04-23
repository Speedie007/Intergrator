using Integrator.Models.ViewModels.CurriculumVitaes;
using Integrator.Models.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Integrator.Factories.CurriculumVitae
{
    public partial interface ICurriculumVitaeViewModelFactory
    {
        CurriculumVitaeViewModel PerpareCurriculumVitaeViewModel(CurriculumVitaeViewModel model, Boolean DisplayFullCurriculumVitae);

        EditUserCurriculumViteaWorkExperienceViewModel prepareEditCurriuclumVitaeWorkExperiences();

        EditUserQualificationViewModel prepareEditCurriuclumVitaeQualifications();

        EditUserInterestViewModel prepareEditCurriculumVitaeInterests();

        EditUserLanguageViewModel PrepareEditCurriculumVitaeLanguages();

        EditUserAwardViewModel PrepareEditCurriculumVitaeAwards();

        EditUserPictureViewModel PrepareEditCurriculumViteaPictures();
        // EditUserCurriculumVitaePictureViewModel

    }
}
