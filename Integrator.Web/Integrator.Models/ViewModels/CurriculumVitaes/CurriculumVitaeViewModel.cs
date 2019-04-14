using Integrator.Models.ViewModels.Common;
using Integrator.Models.ViewModels.Users;
using Integrator.Models.ViewModels.ViewModelBaseComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Integrator.Models.ViewModels.CurriculumVitaes
{
    public partial class CurriculumVitaeViewModel : BaseIntegratorEntityModel
    {

        #region Cstor

        public CurriculumVitaeViewModel()
        {
            ContactDetails = new List<UserContactDetailViewModel>();
            UserQualifications = new List<UserQualificationViewModel>();
            UserLanguages = new List<UserLanguageViewModel>();
            UserInterests = new List<UserInterestViewModel>();
            UserWorkExperiences = new List<CurriculumViteaWorkExperienceViewModel>();
            UserAwards = new List<UserAwardViewModel>();
            UserJobSummary = new List<UserJobSummaryViewModel>();
        }
        #endregion
        public string UserPictureImageType { get; set; }
        public byte[] UserPicture { get; set; }

        [Display(Name ="Date Last Update")]
        public DateTime DateLastUpdated { get; set; }

        [Display(Name = "Name")]
        public string UserFirstName { get; set; }

        [Display(Name = "Surname")]
        public string UserLastName { get; set; }

        [Display(Name = "Career Summary")]
        public string UserCareerSummary { get; set; }

        public string CurrentJobTitle { get; set; }

        public string FullName => $"{UserFirstName} {UserLastName}";

        public IList<UserAwardViewModel> UserAwards { get; set; }

        public IList<UserContactDetailViewModel> ContactDetails { get; set; }

        public IList<UserQualificationViewModel> UserQualifications { get; set; }

        public IList<UserLanguageViewModel> UserLanguages { get; set; }

        public IList<UserInterestViewModel> UserInterests { get; set; }

        public IList<CurriculumViteaWorkExperienceViewModel> UserWorkExperiences { get; set; }

        public IList<UserJobSummaryViewModel> UserJobSummary { get; set; }

    }
}
