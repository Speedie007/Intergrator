using Integrator.Models.ViewModels.CurriculumVitaes;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.ViewModels.Users
{
   public partial class EditUserCurriculumViteaWorkExperienceViewModel: CurriculumViteaWorkExperienceViewModel
    {
        public EditUserCurriculumViteaWorkExperienceViewModel() {
            ListOfCompanies = new List<SelectListItem>();
        }

        public int CompamyID { get; set; }
        public ICollection<SelectListItem> ListOfCompanies { get; set; }
    }
}
