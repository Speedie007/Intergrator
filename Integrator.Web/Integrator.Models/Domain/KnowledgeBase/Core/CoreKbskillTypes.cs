using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.KnowledgeBase.Core
{
    public partial class CoreKbSkillType : BaseEntity
    {
        public CoreKbSkillType()
        {
            CoreSkillCategories = new HashSet<CoreSkillCategory>();
        }


        public string CoreKbSkillTypeName { get; set; }

        public virtual ICollection<CoreSkillCategory> CoreSkillCategories { get; set; }
    }
}
