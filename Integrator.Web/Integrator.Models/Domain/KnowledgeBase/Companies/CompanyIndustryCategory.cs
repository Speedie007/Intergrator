using Integrator.Models.Domain.Companies;
using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.KnowledgeBase.Companies
{
    public partial class CompanyIndustryCategory : BaseEntity
    {
        public CompanyIndustryCategory()
        {
            CompanyIndustryCategoryJobs = new HashSet<CompanyIndustryCategoryJob>();
        }

       
        public int CompanyID { get; set; }

        public int CoreKBIndustryCategoryID { get; set; }

        public int CompanyIndustryID { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }

        public virtual Company Company { get; set; }

        public virtual CompanyIndustry CompanyIndustry { get; set; }

        public virtual CoreKBIndustryCategory CoreKBIndustryCategory { get; set; }

        public virtual ICollection<CompanyIndustryCategoryJob> CompanyIndustryCategoryJobs { get; set; }
    }
}