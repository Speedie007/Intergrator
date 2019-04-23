using Integrator.Models.ViewModels.ViewModelBaseComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Integrator.Models.ViewModels.KnowledgeBase
{
    public partial class CoreKbSkillViewModel : BaseIntegratorEntityModel
    {
        #region Cstor
        public CoreKbSkillViewModel()
        {

        }
        #endregion

        [Display(Name="Skill")]
        public string CoreSkill { get; set; }
        [Display(Name = "Skill Type")]
        public string CoreSkillType { get; set; }
        [Display(Name = "Category")]
        public string CoreSkillCategory { get; set; }



    }
}
