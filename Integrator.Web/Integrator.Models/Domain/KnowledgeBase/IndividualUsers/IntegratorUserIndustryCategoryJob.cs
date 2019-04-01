using Integrator.Models.Domain.Authentication;
using Integrator.Models.Domain.CurriculumVitaes;
using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.KnowledgeBase.IndividualUsers
{
    public partial class IntegratorUserIndustryCategoryJob : BaseEntity
    {
        public IntegratorUserIndustryCategoryJob()
        {
            IntegratorUserIndustryCategoryJobSkillSets = new HashSet<IntegratorUserIndustryCategoryJobSkillSet>();

            #region Curriculum Vitae
            CurriculumViteaWorkExperiences = new HashSet<CurriculumViteaWorkExperiences>();
            #endregion
        }

        public int IntegratorUserID { get; set; }

        public int IntegratorUserIndustryCategoryID { get; set; }

        public int CoreKBIndustryCategoryJobID { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }

        public Boolean IsPrimaryJobFunction { get; set;  }

        public virtual IntegratorUser IntegratorUser { get; set; }


        #region User KnowledgeBase
        public virtual CoreKBIndustryCategoryJob CoreKBIndustryCategoryJob { get; set; }
        public virtual IntegratorUserIndustryCategory IntegratorUserIndustryCategory { get; set; }
        public virtual ICollection<IntegratorUserIndustryCategoryJobSkillSet> IntegratorUserIndustryCategoryJobSkillSets { get; set; }
        #endregion
        #region Curriculum Vitae
        public virtual ICollection<CurriculumViteaWorkExperiences> CurriculumViteaWorkExperiences { get; set; }
        #endregion
    }
}