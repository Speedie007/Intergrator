using Integrator.Models.Domain.KnowledgeBase.Company;
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
        }

        //[Column("CompanyID")]
        //public int CompanyId { get; set; }
        [StringLength(50)]
        public string CompanyName { get; set; }

        [InverseProperty("Company")]
        public virtual ICollection<CompanyIndustry> CompanyIndustries { get; set; }
        [InverseProperty("Company")]
        public virtual ICollection<CompanyIndustryCategory> CompanyIndustryCategories { get; set; }
        [InverseProperty("Company")]
        public virtual ICollection<CompanyIndustryCategoryJobSkillSet> CompanyIndustryCategoryJobSkillSets { get; set; }
        [InverseProperty("Company")]
        public virtual ICollection<CompanyIndustryCategoryJob> CompanyIndustryCategoryJobs { get; set; }
    }
}
