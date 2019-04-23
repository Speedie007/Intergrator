using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.KnowledgeBase.Core
{
    public partial class CoreKbJobSkill : BaseEntity
    {

        public int CoreKbJobID { get; set; }
        public int CoreKbSkillID { get; set; }

        public virtual CoreKbJob CoreJob { get; set; }
        public virtual CoreKbSkill CoreSkill { get; set; }
    }
}