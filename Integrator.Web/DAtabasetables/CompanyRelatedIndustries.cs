using System;
using System.Collections.Generic;

namespace DAtabasetables
{
    public partial class CompanyRelatedIndustries
    {
        public CompanyRelatedIndustries()
        {
            CompanyRelatedIndustryRepresentives = new HashSet<CompanyRelatedIndustryRepresentives>();
        }

        public int CompanyRelatedIndustryId { get; set; }
        public int CoreKbindustryId { get; set; }
        public int CompanyId { get; set; }

        public virtual ICollection<CompanyRelatedIndustryRepresentives> CompanyRelatedIndustryRepresentives { get; set; }
    }
}