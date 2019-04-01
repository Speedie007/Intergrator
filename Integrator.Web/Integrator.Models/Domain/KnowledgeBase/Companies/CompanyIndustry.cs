using Integrator.Models.Domain.KnowledgeBase.Core;
using Integrator.Models.Domain.Companies;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Integrator.Models.Domain.KnowledgeBase.Companies
{
    public partial class CompanyIndustry : BaseEntity
    {
        public CompanyIndustry()
        {
            CompanyIndustryCategories = new HashSet<CompanyIndustryCategory>();
        }

        public int CompanyID { get; set; }

        public int CoreKBIndustryID { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }

        public Company Company { get; set; }

        public virtual CoreKBIndustryType CoreKBIndustry { get; set; }
       
         public virtual ICollection<CompanyIndustryCategory> CompanyIndustryCategories { get; set; }
    }
}