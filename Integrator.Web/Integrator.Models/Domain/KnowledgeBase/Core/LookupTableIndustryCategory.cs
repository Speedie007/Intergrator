using Integrator.Models.Domain.KnowledgeBase.Company;
using Integrator.Models.Domain.KnowledgeBase.IndividualUser;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.KnowledgeBase.Core
{
    
    public partial class LookupTableIndustryCategory : BaseEntity
    {
        public LookupTableIndustryCategory()
        {
            CompanyIndustryCategories = new HashSet<CompanyIndustryCategory>();
            IntegratorUserIndustryCategories = new HashSet<IntegratorUserIndustryCategory>();
            LookupTableIndustryCategoryJobs = new HashSet<LookupTableIndustryCategoryJob>();
        }

        //[Column("IndustryCategoryID")]
        //public int IndustryCategoryID { get; set; }
        [Column("IndustryID")]
        public int IndustryID { get; set; }

        [ForeignKey("IndustryID")]
        [InverseProperty("LookupTableIndustryCategories")]
        public virtual LookupTableIndustryType Industry { get; set; }
        [InverseProperty("IndustryCategory")]
        public virtual ICollection<CompanyIndustryCategory> CompanyIndustryCategories { get; set; }
        [InverseProperty("IndustryCategory")]
        public virtual ICollection<IntegratorUserIndustryCategory> IntegratorUserIndustryCategories { get; set; }
        [InverseProperty("IndustryCategory")]
        public virtual ICollection<LookupTableIndustryCategoryJob> LookupTableIndustryCategoryJobs { get; set; }
    }
}