using Integrator.Models.ViewModels.ViewModelBaseComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Integrator.Models.ViewModels.Users
{
    public partial class UserIndustryViewModel : BaseIntegratorEntityModel
    {
        
        [Display(Name = "Industry")]
        public string JobIndustry { get; set; }

        [Display(Name = "Involvement Level")]
        public int IndustryLevelInvolvement { get; set; }

        [Display(Name = "Category")]
        public string IndustryCategoryName { get; set; }

        public int IndustryCategoryID { get; set; }
    }
}
