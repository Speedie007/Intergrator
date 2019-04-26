using Integrator.Models.Domain.EnumClasses;
using Integrator.Models.ViewModels.CurriculumVitaes;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
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
            ListOfUserRelatedIndustries = new List<InternalReturnItem>();
            ListOfUserSkills = new List<InternalReturnItem>();
            ListOfUserJobs = new List<CurriculumViteaWorkExperienceViewModel>();
            ListOfSelectedSkillAndIndustryForEntry = new List<InternalWorkExperienceDataStructure>();
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

        public List<InternalReturnItem> ListOfUserRelatedIndustries { get; set; }
        public List<InternalReturnItem> ListOfUserSkills { get; set; }

        public List<CurriculumViteaWorkExperienceViewModel> ListOfUserJobs { get; set; }

        public List<InternalWorkExperienceDataStructure> ListOfSelectedSkillAndIndustryForEntry { get; set; }

    }
    #region Internal helper class
    public class InternalReturnItem
    {
        public string DataItemID { get; set; }
        public string DataItemTEXT { get; set; }
        public string DataItemLevel { get; set; }
    }

    public class InternalWorkExperienceDataStructure
    {

        public InternalWorkExperienceDataStructure()
        {
            SelectedDataItem = new InternalReturnItem();
        }
        public string DataType { get; set; }
        public string SelectedCategory { get; set; }
        public int SelectedCategoryID { get; set; }
        public InternalReturnItem SelectedDataItem { get; set; }
    }
    #endregion
}
