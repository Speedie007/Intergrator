using Integrator.Models.ViewModels.CurriculumVitaes;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.ViewModels.Users
{
    public partial class EditUserCurriculumViteaWorkExperienceViewModel : CurriculumViteaWorkExperienceViewModel
    {
        public EditUserCurriculumViteaWorkExperienceViewModel()
        {
            ListOfCompanies = new List<SelectListItem>();
            ListOfIndustryCategories = new List<SelectListItem>();
            ListOfHardSkillCategories = new List<SelectListItem>();
            ListOfSoftSkillCategories = new List<SelectListItem>();
            ListOfJobTitles = new List<SelectListItem>();
        }
        public string CompanyID { get; set; }
        public ICollection<SelectListItem> ListOfCompanies { get; set; }

        public string IndustryCategoryID { get; set; }
        public List<SelectListItem> ListOfIndustryCategories { get; set; }

        public string HardSKillCategoryID { get; set; }
        public List<SelectListItem> ListOfHardSkillCategories { get; set; }


        public string SoftSKillCategoryID { get; set; }
        public List<SelectListItem> ListOfSoftSkillCategories { get; set; }

        public string CoreKbJobID { get; set; }
        public List<SelectListItem> ListOfJobTitles { get; set; }

    }
}
