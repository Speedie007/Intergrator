using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.KnowledgeBase.IndividualUsers
{
    public partial class UserJobRelatedIndustry:BaseEntity
    {
        
        public int UserJobID { get; set; }
        public int CoreKbIndustryID { get; set; }
        public int LevelOfIndustInvolvement { get; set; }

        public virtual CoreKbIndustry CoreKbIndustry { get; set; }
        public virtual UserJob UserJob { get; set; }
    }
}