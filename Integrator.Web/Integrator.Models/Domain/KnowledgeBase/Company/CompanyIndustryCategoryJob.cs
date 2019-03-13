using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.KnowledgeBase.Company
{
    public partial class CompanyIndustryCategoryJob : BaseEntity
    {
        public CompanyIndustryCategoryJob()
        {
            CompanyIndustryCategoryJobSkillSets = new HashSet<CompanyIndustryCategoryJobSkillSet>();
        }

        //[Column("CompanyIndustryCategoryJobID")]
        //public int CompanyIndustryCategoryJobID { get; set; }
        [Column("CompanyID")]
        public int CompanyID { get; set; }
        [Column("CompanyIndustryCategoryID")]
        public int CompanyIndustryCategoryID { get; set; }
        [Column("IndustryCategoryJobID")]
        public int IndustryCategoryJobID { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }

        [ForeignKey("CompanyID")]
        [InverseProperty("CompanyIndustryCategoryJobs")]
        public virtual Integrator.Models.Domain.Companies.Company Company { get; set; }
        [ForeignKey("CompanyIndustryCategoryID")]
        [InverseProperty("CompanyIndustryCategoryJobs")]
        public virtual CompanyIndustryCategory CompanyIndustryCategory { get; set; }
        [ForeignKey("IndustryCategoryJobID")]
        [InverseProperty("CompanyIndustryCategoryJobs")]
        public virtual LookupTableIndustryCategoryJob IndustryCategoryJob { get; set; }
        [InverseProperty("CompanyIndustryCategoryJob")]
        public virtual ICollection<CompanyIndustryCategoryJobSkillSet> CompanyIndustryCategoryJobSkillSets { get; set; }
    }
}