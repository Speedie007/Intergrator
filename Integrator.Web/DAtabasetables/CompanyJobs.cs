using System;
using System.Collections.Generic;

namespace DAtabasetables
{
    public partial class CompanyJobs
    {
        public CompanyJobs()
        {
            CompanyJobRepresentitives = new HashSet<CompanyJobRepresentitives>();
        }

        public int CompanyJobId { get; set; }
        public int CompanyId { get; set; }
        public int CoreKbjobId { get; set; }
        public string JobDescription { get; set; }

        public virtual ICollection<CompanyJobRepresentitives> CompanyJobRepresentitives { get; set; }
    }
}