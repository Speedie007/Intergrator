using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.KnowledgeBase.Core
{
    public partial class CoreKbIndustryJob : BaseEntity
    {
        
        public int CoreKbIndustryID { get; set; }
        public int CoreKbJobID { get; set; }

        public virtual CoreKbIndustry CoreKbIndustry { get; set; }
        public virtual CoreKbJob CoreKbJob { get; set; }
    }
}