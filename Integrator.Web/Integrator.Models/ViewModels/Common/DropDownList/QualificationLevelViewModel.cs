using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.ViewModels.Common.DropDownList
{
    public partial class QualificationLevelViewModel
    {
        public string QualificationLevel { get; set; }
        public List<SelectListItem> QualifiactionLevels { get; set; }
    }
}
