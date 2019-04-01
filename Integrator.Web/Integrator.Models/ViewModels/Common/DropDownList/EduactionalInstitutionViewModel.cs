using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.ViewModels.Common.DropDownList
{
   public partial  class EduactionalInstitutionViewModel
    {
        public int EductaionalInstitutionID { get; set; }
        public List<SelectListItem> EductaionalInstitutions { get; set; }
    }
}
