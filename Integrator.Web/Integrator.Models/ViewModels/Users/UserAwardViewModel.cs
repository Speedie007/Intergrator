using Integrator.Models.ViewModels.ViewModelBaseComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.ViewModels.Users
{
    public partial class UserAwardViewModel : BaseIntegratorEntityModel
    {
        public string AwardTitle { get; set; }
        public string AwardDescription { get; set; }
    }
}
