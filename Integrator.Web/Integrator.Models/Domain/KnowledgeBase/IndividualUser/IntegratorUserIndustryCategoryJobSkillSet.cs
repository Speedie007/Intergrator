using Integrator.Models.Domain.Authentication;
using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.KnowledgeBase.IndividualUser
{
    public partial class IntegratorUserIndustryCategoryJobSkillSet : BaseEntity
    {
        //[Column("IntegratorUserIndustryCategoryJobSkillSetID")]
        //public int IntegratorUserIndustryCategoryJobSkillSetID { get; set; }
        [Column("IntegratorUserID")]
        public int IntegratorUserID { get; set; }
        [Column("IntegratorUserIndustryCategoryJobID")]
        public int IntegratorUserIndustryCategoryJobID { get; set; }
        [Column("IndustryCategorySkillSetID")]
        public int IndustryCategorySkillSetID { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }

        [ForeignKey("IndustryCategorySkillSetID")]
        [InverseProperty("IntegratorUserIndustryCategoryJobSkillSets")]
        public virtual LookupTableIndustryCategoryJobSkillSet IndustryCategorySkillSet { get; set; }
        [ForeignKey("IntegratorUserID")]
        [InverseProperty("IntegratorUserIndustryCategoryJobSkillSets")]
        public virtual IntegratorUser IntegratorUser { get; set; }
        [ForeignKey("IntegratorUserIndustryCategoryJobID")]
        [InverseProperty("IntegratorUserIndustryCategoryJobSkillSets")]
        public virtual IntegratorUserIndustryCategoryJob IntegratorUserIndustryCategoryJob { get; set; }
    }
}