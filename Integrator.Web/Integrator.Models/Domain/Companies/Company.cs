//using Integrator.Models.Domain.KnowledgeBase.Companies;
using Integrator.Models.Domain.CurriculumVitaes;
using Integrator.Models.Domain.KnowledgeBase.Companies;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Integrator.Models.Domain.Companies
{
    public partial class Company : BaseEntity
    {
        public Company()
        {
            CompanyIndustries = new HashSet<CompanyIndustry>();
            CompanyIndustryCategories = new HashSet<CompanyIndustryCategory>();
            CompanyIndustryCategoryJobSkillSets = new HashSet<CompanyIndustryCategoryJobSkillSet>();
            CompanyIndustryCategoryJobs = new HashSet<CompanyIndustryCategoryJob>();
            #region CV
            CurriculumViteaWorkExperiences = new HashSet<CurriculumViteaWorkExperiences>();
            #endregion
        }

        [StringLength(100)]
        public string CompanyName { get; set; }
        
        #region Company Kownledge Base

        public virtual ICollection<CompanyIndustry> CompanyIndustries { get; set; }
        public virtual ICollection<CompanyIndustryCategory> CompanyIndustryCategories { get; set; }
        public virtual ICollection<CompanyIndustryCategoryJobSkillSet> CompanyIndustryCategoryJobSkillSets { get; set; }
        public virtual ICollection<CompanyIndustryCategoryJob> CompanyIndustryCategoryJobs { get; set; }
        #endregion

        #region CV

        public virtual ICollection<CurriculumViteaWorkExperiences> CurriculumViteaWorkExperiences { get; set; }
        #endregion
    }
}
