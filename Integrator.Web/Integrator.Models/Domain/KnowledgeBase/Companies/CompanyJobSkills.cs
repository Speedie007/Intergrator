using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.KnowledgeBase.Companies
{
    public partial class CompanyJobSkill:BaseEntity
    {
        
        public int CompanyJobID { get; set; }
        public int CoreKbSkillID { get; set; }
        public int LevelOfImportantce { get; set; }

        public virtual CompanyJob CompanyJob { get; set; }
        public virtual CoreKbSkill CoreKbSkill { get; set; }
    }
}