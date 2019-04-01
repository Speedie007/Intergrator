using Integrator.Models.ViewModels.Common.DropDownList;
using Integrator.Models.ViewModels.ViewModelBaseComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Integrator.Models.ViewModels.Users
{
    public partial class UserQualificationViewModel : BaseIntegratorEntityModel
    {
        [Required]
        [Display(Name = "Qualification")]
        public virtual string QualificationTitle { get; set; }

        [Display(Name = "Institution")]
        public virtual string EductaionalInstitution { get; set; }

        [Display(Name = "Level")]
        public virtual string QualificationLevel { get; set; }

        [Display(Name = "Year Started")]
        public virtual string YearStartedQualification { get; set; }

        [Display(Name = "Year Completed")]
        public virtual string YearCompletedQualification { get; set; }

        public virtual string YearStartEndQualification => $"{YearStartedQualification} - {YearCompletedQualification}";

        [Display(Name = "Qualification Average")]
        public virtual double QualificationAverage { get; set; }


    }
}
