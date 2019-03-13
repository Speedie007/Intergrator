using Integrator.Models.Domain.KnowledgeBase.Company;
using Integrator.Models.Domain.KnowledgeBase.IndividualUser;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.KnowledgeBase.Core
{
    
    public partial class LookupTableIndustryType : BaseEntity
    {
        public LookupTableIndustryType()
        {
            CompanyIndustries = new HashSet<CompanyIndustry>();
            IntegratorUserIndustries = new HashSet<IntegratorUserIndustry>();
            LookupTableIndustryCategories = new HashSet<LookupTableIndustryCategory>();
        }

        //[Column("IndustryID")]
        //public int IndustryID { get; set; }
        [StringLength(50)]
        public string Industry { get; set; }

        [InverseProperty("Industry")]
        public virtual ICollection<CompanyIndustry> CompanyIndustries { get; set; }
        [InverseProperty("Industry")]
        public virtual ICollection<IntegratorUserIndustry> IntegratorUserIndustries { get; set; }
        [InverseProperty("Industry")]
        public virtual ICollection<LookupTableIndustryCategory> LookupTableIndustryCategories { get; set; }
    }
}