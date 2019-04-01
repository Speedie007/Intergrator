using Integrator.Models.ViewModels.ViewModelBaseComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Integrator.Models.ViewModels.Users
{
    public partial class UserInterestViewModel : BaseIntegratorEntityModel
    {
        public string Interest { get; set; }
        [Display(Name = "Level")]
        public double InterestLevel { get; set; }

    }
}
