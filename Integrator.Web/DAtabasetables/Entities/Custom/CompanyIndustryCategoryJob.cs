using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAtabasetables.Entities.Custom
{
    public partial class CompanyIndustryCategoryJob
    {
        public CompanyIndustryCategoryJob()
        {
            CompanyIndustryCategoryJobSkillSets = new HashSet<CompanyIndustryCategoryJobSkillSet>();
        }

        [Column("CompanyIndustryCategoryJobID")]
        public int CompanyIndustryCategoryJobId { get; set; }
        [Column("CompanyID")]
        public int CompanyId { get; set; }
        [Column("CompanyIndustryCategoryID")]
        public int CompanyIndustryCategoryId { get; set; }
        [Column("IndustryCategoryJobID")]
        public int IndustryCategoryJobId { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }

        [ForeignKey("CompanyId")]
        [InverseProperty("CompanyIndustryCategoryJobs")]
        public virtual Company Company { get; set; }
        [ForeignKey("CompanyIndustryCategoryId")]
        [InverseProperty("CompanyIndustryCategoryJobs")]
        public virtual CompanyIndustryCategory CompanyIndustryCategory { get; set; }
        [ForeignKey("IndustryCategoryJobId")]
        [InverseProperty("CompanyIndustryCategoryJobs")]
        public virtual LookupTableIndustryCategoryJob IndustryCategoryJob { get; set; }
        [InverseProperty("CompanyIndustryCategoryJob")]
        public virtual ICollection<CompanyIndustryCategoryJobSkillSet> CompanyIndustryCategoryJobSkillSets { get; set; }
    }
}