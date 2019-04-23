using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.KnowledgeBase.Core
{
    public partial class CoreKbIndustryCategory:BaseEntity
    {
        public CoreKbIndustryCategory()
        {
            CoreKbIndustries = new HashSet<CoreKbIndustry>();
        }

        
        public string CoreKbIndustryCategoryName { get; set; }

        public virtual ICollection<CoreKbIndustry> CoreKbIndustries { get; set; }
    }
}