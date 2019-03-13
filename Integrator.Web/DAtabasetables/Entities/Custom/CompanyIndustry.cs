using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAtabasetables.Entities.Custom
{
    public partial class CompanyIndustry
    {
        public CompanyIndustry()
        {
            CompanyIndustryCategories = new HashSet<CompanyIndustryCategory>();
        }

        [Column("CompanyIndustryID")]
        public int CompanyIndustryId { get; set; }
        [Column("CompanyID")]
        public int? CompanyId { get; set; }
        [Column("IndustryID")]
        public int IndustryId { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }

        [ForeignKey("CompanyId")]
        [InverseProperty("CompanyIndustries")]
        public virtual Company Company { get; set; }
        [ForeignKey("IndustryId")]
        [InverseProperty("CompanyIndustries")]
        public virtual LookupTableIndustryType Industry { get; set; }
        [InverseProperty("CompanyIndustry")]
        public virtual ICollection<CompanyIndustryCategory> CompanyIndustryCategories { get; set; }
    }
}