using Integrator.Models.Domain.Companies;
using Integrator.Models.ViewModels.Users;
using Integrator.Models.ViewModels.ViewModelBaseComponents;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.ViewModels.CurriculumVitaes
{
    public partial class CurriculumViteaWorkExperienceViewModel : BaseIntegratorEntityModel
    {
        public CurriculumViteaWorkExperienceViewModel()
        {
            ListOfHardSkillsEmployed = new List<UserSkillViewModel>();
            ListOfSoftSkillsEmployed = new List<UserSkillViewModel>();

        }

        public string Company { get; set; }
        public string YearStarted { get; set; }
        public string YearEnded { get; set; }
        public string JobTitle { get; set; }
        public string Achievements { get; set; }
        public string WorkExperienceDescription { get; set; }

        public ICollection<UserSkillViewModel> ListOfHardSkillsEmployed { get; set; }
        public ICollection<UserSkillViewModel> ListOfSoftSkillsEmployed { get; set; }
    }
}
