using Integrator.Models.Domain.KnowledgeBase.Companies;
using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.KnowledgeBase.Core
{
    public partial class CoreKbSkill : BaseEntity
    {
        public CoreKbSkill()
        {
            CompanyJobSkills = new HashSet<CompanyJobSkill>();
            CoreKbJobSkills = new HashSet<CoreKbJobSkill>();
            UserJobSkills = new HashSet<UserJobSkill>();
        }
        
        public int CoreSkillCategoryID { get; set; }
        public string CoreSkill { get; set; }

        //public virtual CoreKbSkillType CoreKbSkillType { get; set; }
        public virtual CoreSkillCategory CoreSkillCategory { get; set; }
        public virtual ICollection<CompanyJobSkill> CompanyJobSkills { get; set; }
        public virtual ICollection<CoreKbJobSkill> CoreKbJobSkills { get; set; }
        public virtual ICollection<UserJobSkill> UserJobSkills { get; set; }
    }
}
