using Integrator.Models.Domain.Authentication;
using Integrator.Models.Domain.CurriculumVitaes;
using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.KnowledgeBase.IndividualUsers
{
    public partial class IntegratorUserIndustryCategoryJobSkillSet : BaseEntity
    {
        public IntegratorUserIndustryCategoryJobSkillSet()
        {
            #region Curriculum Vitae
            CurriculumViteaWorkExperienceSkillSets = new HashSet<CurriculumViteaWorkExperienceSkillSets>();
            #endregion
        }
        public int IntegratorUserID { get; set; }

        public int IntegratorUserIndustryCategoryJobID { get; set; }

        public int CoreKBIndustryCategorySkillSetID { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }
        public decimal SkillLevel { get; set; }

        public virtual CoreKBIndustryCategoryJobSkillSet CoreKBIndustryCategoryJobSkillSet { get; set; }

        public virtual IntegratorUser IntegratorUser { get; set; }

        public virtual IntegratorUserIndustryCategoryJob IntegratorUserIndustryCategoryJob { get; set; }

        #region Curriculum Vitae
        public virtual ICollection<CurriculumViteaWorkExperienceSkillSets> CurriculumViteaWorkExperienceSkillSets { get; set; }
        #endregion
    }
}