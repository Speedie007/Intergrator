using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.ViewModels.KnowledgeBase
{
    public partial class EditCoreKbSkillViewModel : CoreKbSkillViewModel
    {
        public EditCoreKbSkillViewModel()
        {
            ListOfSkills = new List<CoreKbSkillViewModel>();

            ListOfSkillTypes = new List<SelectListItem>();
            ListOfSkillCategories = new List<SelectListItem>();
        }

        public string CoreKbSkillID { get; set; }
        public List<CoreKbSkillViewModel> ListOfSkills { get; set; }


        public string CoreSkillCategoryID { get; set; }
        public List<SelectListItem> ListOfSkillCategories { get; set; }

        public string CoreKbskillTypeID { get; set; }
        public List<SelectListItem> ListOfSkillTypes { get; set; }
    }
}
