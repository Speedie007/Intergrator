using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.KnowledgeBase.Core
{
    public partial class CoreSkillCategory : BaseEntity
    {
        public CoreSkillCategory()
        {
            CoreKbSkills = new HashSet<CoreKbSkill>();
        }

        public int CoreKbSkillTypeID { get; set; }
        public string CoreSkillCategoryName { get; set; }

        public virtual CoreKbSkillType CoreKbSkillType { get; set; }
        public virtual ICollection<CoreKbSkill> CoreKbSkills { get; set; }
    }
}


