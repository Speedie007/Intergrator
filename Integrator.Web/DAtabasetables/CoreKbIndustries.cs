using System;
using System.Collections.Generic;

namespace DAtabasetables
{
    public partial class CoreKbIndustries
    {
        public CoreKbIndustries()
        {
            CompanyRelatedIndustries = new HashSet<CompanyRelatedIndustries>();
            CoreKbIndustrySectors = new HashSet<CoreKbIndustrySectors>();
        }

        public int CoreKbIndustryId { get; set; }
        public int CoreKbIndustryCategoryId { get; set; }
        public string CoreKbindustryName { get; set; }

        public virtual ICollection<CompanyRelatedIndustries> CompanyRelatedIndustries { get; set; }
        public virtual ICollection<CoreKbIndustrySectors> CoreKbIndustrySectors { get; set; }
    }
}