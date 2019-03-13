using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAtabasetables.Entities.Custom
{
    public partial class CompanyIndustryCategory
    {
        public CompanyIndustryCategory()
        {
            CompanyIndustryCategoryJobs = new HashSet<CompanyIndustryCategoryJob>();
        }

        [Column("CompanyIndustryCategoryID")]
        public int CompanyIndustryCategoryId { get; set; }
        [Column("CompanyID")]
        public int CompanyId { get; set; }
        [Column("IndustryCategoryID")]
        public int IndustryCategoryId { get; set; }
        [Column("CompanyIndustryID")]
        public int CompanyIndustryId { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }

        [ForeignKey("CompanyId")]
        [InverseProperty("CompanyIndustryCategories")]
        public virtual Company Company { get; set; }
        [ForeignKey("CompanyIndustryId")]
        [InverseProperty("CompanyIndustryCategories")]
        public virtual CompanyIndustry CompanyIndustry { get; set; }
        [ForeignKey("IndustryCategoryId")]
        [InverseProperty("CompanyIndustryCategories")]
        public virtual LookupTableIndustryCategory IndustryCategory { get; set; }
        [InverseProperty("CompanyIndustryCategory")]
        public virtual ICollection<CompanyIndustryCategoryJob> CompanyIndustryCategoryJobs { get; set; }
    }
}