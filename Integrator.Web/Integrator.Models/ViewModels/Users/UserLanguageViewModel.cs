using Integrator.Models.ViewModels.ViewModelBaseComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Integrator.Models.ViewModels.Users
{
    public partial class UserLanguageViewModel : BaseIntegratorEntityModel
    {

        public string Language { get; set; }
        [Display(Name = "Is primary langauge")]
        public Boolean IsPrimaryLanguage { get; set; }
        [Display(Name = "Can speak & write")]
        public Boolean CanSpeakAndWrite { get; set; }

    }
}
