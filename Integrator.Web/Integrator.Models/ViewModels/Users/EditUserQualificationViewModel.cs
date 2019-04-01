using Integrator.Models.ViewModels.ViewModelBaseComponents;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Integrator.Models.ViewModels.Users
{
    public partial class EditUserQualificationViewModel : UserQualificationViewModel
    {
        public EditUserQualificationViewModel()
        {
            UserQualifications = new List<UserQualificationViewModel>();
            QualificationLevels = new List<SelectListItem>();
            EductaionalInstitutions = new List<SelectListItem>();
        }

        public virtual ICollection<UserQualificationViewModel> UserQualifications { get; set; }

        public virtual int QualificationLevelID { get; set; }

        [Display(Name = "Qualifications")]
        public List<SelectListItem> QualificationLevels { get; set; }

        public virtual int EductaionalInstitutionID { get; set; }

        [Display(Name = "Institutions")]
        public virtual List<SelectListItem> EductaionalInstitutions { get; set; }

              

    }
}
