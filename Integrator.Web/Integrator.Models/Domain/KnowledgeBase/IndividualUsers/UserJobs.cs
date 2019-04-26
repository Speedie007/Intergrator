using Integrator.Models.Domain.Authentication;
using Integrator.Models.Domain.Companies;
using Integrator.Models.Domain.CurriculumVitaes;
using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.KnowledgeBase.IndividualUsers
{
    [Serializable]
    public partial class UserJob : BaseEntity
    {
        public UserJob()
        {
            UserJobRelatedIndustries = new HashSet<UserJobRelatedIndustry>();
            UserJobSkills = new HashSet<UserJobSkill>();
        }


        public int CurriculumViteaID { get; set; }
        public int IntegratorUserID { get; set; }
        public int CoreKbJobID { get; set; }
        public int CompanyID { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateEnded { get; set; }
        public string Achievments { get; set; }
        public string WorkExperienceDescription { get; set; }
        public bool IsCurrentJob { get; set; }

        public virtual CoreKbJob CoreKbJob { get; set; }
        public virtual CurriculumVitea CurriculumVitea { get; set; }
        public virtual ICollection<UserJobRelatedIndustry> UserJobRelatedIndustries { get; set; }
        public virtual ICollection<UserJobSkill> UserJobSkills { get; set; }

        public virtual IntegratorUser IntegratorUser { get; set; }

        public virtual Company Company { get; set; }
    }
}