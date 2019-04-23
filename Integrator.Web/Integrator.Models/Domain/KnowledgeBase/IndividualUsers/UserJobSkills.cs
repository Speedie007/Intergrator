using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.KnowledgeBase.IndividualUsers
{
    public partial class UserJobSkill : BaseEntity
    {
        
        public int UserJobID { get; set; }
        public int CoreKbSkillID { get; set; }
        public int UserJobSkillLevel { get; set; }

        public virtual CoreKbSkill CoreKbSkill { get; set; }
        public virtual UserJob UserJob { get; set; }
    }
}