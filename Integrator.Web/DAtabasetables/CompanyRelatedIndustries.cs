using System;
using System.Collections.Generic;

namespace DAtabasetables
{
    public partial class CompanyRelatedIndustries
    {
        public CompanyRelatedIndustries()
        {
            CompanyRelatedIndustrySectors = new HashSet<CompanyRelatedIndustrySectors>();
        }

        public int CompanyRelatedIndustryId { get; set; }
        public int CoreKbIndustryId { get; set; }
        public int CompanyId { get; set; }

        public virtual CoreKbIndustries CoreKbIndustry { get; set; }
        public virtual ICollection<CompanyRelatedIndustrySectors> CompanyRelatedIndustrySectors { get; set; }
    }
}