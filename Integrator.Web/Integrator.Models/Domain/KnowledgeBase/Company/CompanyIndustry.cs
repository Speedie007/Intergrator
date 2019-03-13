using Integrator.Models.Domain.Companies;
using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.KnowledgeBase.Company
{
    public partial class CompanyIndustry : BaseEntity
    {
        public CompanyIndustry()
        {
            CompanyIndustryCategories = new HashSet<CompanyIndustryCategory>();
        }

        //[Column("CompanyIndustryID")]
        //public int CompanyIndustryID { get; set; }
        [Column("CompanyID")]
        public int? CompanyID { get; set; }
        [Column("IndustryID")]
        public int IndustryID { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }

        [ForeignKey("CompanyID")]
        [InverseProperty("CompanyIndustries")]
        public virtual Integrator.Models.Domain.Companies.Company Company { get; set; }
        [ForeignKey("IndustryID")]
        [InverseProperty("CompanyIndustries")]
        public virtual LookupTableIndustryType Industry { get; set; }
        [InverseProperty("CompanyIndustry")]
        public virtual ICollection<CompanyIndustryCategory> CompanyIndustryCategories { get; set; }
    }
}