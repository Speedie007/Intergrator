using Integrator.Models.Domain.KnowledgeBase.Company;
using Integrator.Models.Domain.KnowledgeBase.IndividualUser;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.KnowledgeBase.Core
{
    
    public partial class LookupTableIndustryCategoryJob : BaseEntity
    {
        public LookupTableIndustryCategoryJob()
        {
            CompanyIndustryCategoryJobs = new HashSet<CompanyIndustryCategoryJob>();
            IntegratorUserIndustryCategoryJobs = new HashSet<IntegratorUserIndustryCategoryJob>();
            LookupTableIndustryCategoryJobSkillSets = new HashSet<LookupTableIndustryCategoryJobSkillSet>();
        }

        //[Column("IndustryCategoryJobID")]
        //public int IndustryCategoryJobID { get; set; }
        [Column("IndustryCategoryID")]
        public int IndustryCategoryID { get; set; }
        [StringLength(50)]
        public string JobTitle { get; set; }

        [ForeignKey("IndustryCategoryID")]
        [InverseProperty("LookupTableIndustryCategoryJobs")]
        public virtual LookupTableIndustryCategory IndustryCategory { get; set; }
        [InverseProperty("IndustryCategoryJob")]
        public virtual ICollection<CompanyIndustryCategoryJob> CompanyIndustryCategoryJobs { get; set; }
        [InverseProperty("IndustryCategoryJob")]
        public virtual ICollection<IntegratorUserIndustryCategoryJob> IntegratorUserIndustryCategoryJobs { get; set; }
        [InverseProperty("IndustryCategoryJob")]
        public virtual ICollection<LookupTableIndustryCategoryJobSkillSet> LookupTableIndustryCategoryJobSkillSets { get; set; }
    }
}