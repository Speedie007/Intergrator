using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.KnowledgeBase.Company
{
    public partial class CompanyIndustryCategory : BaseEntity
    {
        public CompanyIndustryCategory()
        {
            CompanyIndustryCategoryJobs = new HashSet<CompanyIndustryCategoryJob>();
        }

        //[Column("CompanyIndustryCategoryID")]
        //public int CompanyIndustryCategoryID { get; set; }

        public int CompanyID { get; set; }
        [Column("IndustryCategoryID")]
        public int IndustryCategoryID { get; set; }
        [Column("CompanyIndustryID")]
        public int CompanyIndustryID { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }

        [ForeignKey("CompanyID")]
        [InverseProperty("CompanyIndustryCategories")]
        public virtual Integrator.Models.Domain.Companies.Company Company { get; set; }
        [ForeignKey("CompanyIndustryID")]
        [InverseProperty("CompanyIndustryCategories")]
        public virtual CompanyIndustry CompanyIndustry { get; set; }
        [ForeignKey("IndustryCategoryID")]
        [InverseProperty("CompanyIndustryCategories")]
        public virtual LookupTableIndustryCategory IndustryCategory { get; set; }
        [InverseProperty("CompanyIndustryCategory")]
        public virtual ICollection<CompanyIndustryCategoryJob> CompanyIndustryCategoryJobs { get; set; }
    }
}