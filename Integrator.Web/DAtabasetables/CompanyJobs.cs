using System;
using System.Collections.Generic;

namespace DAtabasetables
{
    public partial class CompanyJobs
    {
        public CompanyJobs()
        {
            CompnayJobRelatedIndustrySectors = new HashSet<CompnayJobRelatedIndustrySectors>();
        }

        public int CompanyJobId { get; set; }
        public int CompanyId { get; set; }
        public int CoreKbJobId { get; set; }
        public string JobDescription { get; set; }

        public virtual ICollection<CompnayJobRelatedIndustrySectors> CompnayJobRelatedIndustrySectors { get; set; }
    }
}