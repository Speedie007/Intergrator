using Integrator.Models.Domain.KnowledgeBase.Company;
using Integrator.Models.Domain.KnowledgeBase.IndividualUser;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.KnowledgeBase.Core
{
    
    public partial class LookupTableIndustryCategoryJobSkillSet : BaseEntity
    {
        public LookupTableIndustryCategoryJobSkillSet()
        {
            CompanyIndustryCategoryJobSkillSets = new HashSet<CompanyIndustryCategoryJobSkillSet>();
            IntegratorUserIndustryCategoryJobSkillSets = new HashSet<IntegratorUserIndustryCategoryJobSkillSet>();
        }

        //[Column("IndustryCategorySkillSetID")]
        //public int IndustryCategorySkillSetID { get; set; }
        [Column("IndustryCategoryJobID")]
        public int IndustryCategoryJobID { get; set; }
        [StringLength(50)]
        public string IndustryCategorySkillSet { get; set; }

        [ForeignKey("IndustryCategoryJobID")]
        [InverseProperty("LookupTableIndustryCategoryJobSkillSets")]
        public virtual LookupTableIndustryCategoryJob IndustryCategoryJob { get; set; }
        [InverseProperty("IndustryCategorySkillSet")]
        public virtual ICollection<CompanyIndustryCategoryJobSkillSet> CompanyIndustryCategoryJobSkillSets { get; set; }
        [InverseProperty("IndustryCategorySkillSet")]
        public virtual ICollection<IntegratorUserIndustryCategoryJobSkillSet> IntegratorUserIndustryCategoryJobSkillSets { get; set; }
    }
}