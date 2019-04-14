using Integrator.Models.ViewModels.ViewModelBaseComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Integrator.Models.ViewModels.Users
{
    public partial class UserAwardViewModel : BaseIntegratorEntityModel
    {
        [Required]
        [Display(Name = "Award Title")]
        public string AwardTitle { get; set; }
        [Display(Name = "Award Description")]
        public string AwardDescription { get; set; }
    }
}
