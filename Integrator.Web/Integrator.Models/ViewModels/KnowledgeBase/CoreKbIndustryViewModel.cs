using Integrator.Models.Domain.KnowledgeBase.Core;
using Integrator.Models.ViewModels.ViewModelBaseComponents;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.ViewModels.KnowledgeBase
{
    public partial class CoreKbIndustryViewModel : BaseIntegratorEntityModel
    {
        public CoreKbIndustryViewModel()
        {
            ListOfAssocciatedJobs = new List<SelectListItem>();
        }

        public string Industry { get; set; }
        public string Category { get; set; }

        public List<SelectListItem> ListOfAssocciatedJobs { get; set; }
    }
}
