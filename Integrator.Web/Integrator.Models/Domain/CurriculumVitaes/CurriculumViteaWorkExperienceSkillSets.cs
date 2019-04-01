using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.CurriculumVitaes
{
    public partial class CurriculumViteaWorkExperienceSkillSets : BaseEntity
    {
       // public int CurriculumViteaWorkExperienceSkillSetId { get; set; }
        public int CurriculumViteaWorkExperienceID { get; set; }
        public int IntegratorUserIndustryCategoryJobSkillSetID { get; set; }

        public virtual IntegratorUserIndustryCategoryJobSkillSet IntegratorUserIndustryCategoryJobSkillSet { get; set; }
        public virtual CurriculumViteaWorkExperiences CurriculumViteaWorkExperience { get; set; }
    }
}