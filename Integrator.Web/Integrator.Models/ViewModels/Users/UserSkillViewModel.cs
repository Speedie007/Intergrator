using Integrator.Models.Domain.EnumClasses;
using Integrator.Models.ViewModels.ViewModelBaseComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Integrator.Models.ViewModels.Users
{
    public partial class UserSkillViewModel : BaseIntegratorEntityModel
    {
        [Display(Name = "Job Skill")]
        public string JobSkill { get; set; }

        [Display(Name = "Skill Level")]
        public int SkillLevel { get; set; }

        [Display(Name = "Skill Type")]
        public EnumKbSkillType SkillType { get; set; }

        [Display(Name = "Skill Category")]
        public string SkillCategoryName { get; set; }

        public int SkillCategoryID { get; set; }
    }
}
