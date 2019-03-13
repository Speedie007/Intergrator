using Integrator.Models.Domain.Authentication;
using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.KnowledgeBase.IndividualUser
{
    public partial class IntegratorUserIndustryCategoryJob : BaseEntity
    {
        public IntegratorUserIndustryCategoryJob()
        {
            IntegratorUserIndustryCategoryJobSkillSets = new HashSet<IntegratorUserIndustryCategoryJobSkillSet>();
        }

        //[Column("IntegratorUserIndustryCategoryJobID")]
        //public int IntegratorUserIndustryCategoryJobID { get; set; }
        [Column("IntegratorUserID")]
        public int IntegratorUserID { get; set; }
        [Column("IntegratorUserIndustryCategoryID")]
        public int IntegratorUserIndustryCategoryID { get; set; }
        [Column("IndustryCategoryJobID")]
        public int IndustryCategoryJobID { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }

        [ForeignKey("IndustryCategoryJobID")]
        [InverseProperty("IntegratorUserIndustryCategoryJobs")]
        public virtual LookupTableIndustryCategoryJob IndustryCategoryJob { get; set; }
        [ForeignKey("IntegratorUserID")]
        [InverseProperty("IntegratorUserIndustryCategoryJobs")]
        public virtual IntegratorUser IntegratorUser { get; set; }
        [ForeignKey("IntegratorUserIndustryCategoryID")]
        [InverseProperty("IntegratorUserIndustryCategoryJobs")]
        public virtual IntegratorUserIndustryCategory IntegratorUserIndustryCategory { get; set; }
        [InverseProperty("IntegratorUserIndustryCategoryJob")]
        public virtual ICollection<IntegratorUserIndustryCategoryJobSkillSet> IntegratorUserIndustryCategoryJobSkillSets { get; set; }
    }
}