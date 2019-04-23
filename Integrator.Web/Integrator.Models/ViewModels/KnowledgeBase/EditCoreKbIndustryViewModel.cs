using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.ViewModels.KnowledgeBase
{
    public partial class EditCoreKbIndustryViewModel : CoreKbIndustryViewModel
    {
        public EditCoreKbIndustryViewModel()
        {
            ListOfIndustryCategories = new List<SelectListItem>();
        }

        public string IndustryCategoryID { get; set; }
        public List<SelectListItem> ListOfIndustryCategories { get; set; }
    }
}
