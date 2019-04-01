using Integrator.Models.ViewModels.ViewModelBaseComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Integrator.Models.ViewModels.Users
{
    public partial class UserJobSummaryViewModel : BaseIntegratorEntityModel
    {
        public UserJobSummaryViewModel()
        {
            JobSkillSets = new List<UserSkillViewModel>();
        }

        [Display(Name = "Job Description")]
        public virtual string JobTitle { get; set; }

        public virtual Boolean IsPrimaryJobFunction { get; set; }
        public virtual IList<UserSkillViewModel> JobSkillSets { get; set; }

    }
}
