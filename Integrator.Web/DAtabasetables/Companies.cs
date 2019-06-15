using System;
using System.Collections.Generic;

namespace DAtabasetables
{
    public partial class Companies
    {
        public Companies()
        {
            CompanyAddresses = new HashSet<CompanyAddresses>();
            CompanyContactDetails = new HashSet<CompanyContactDetails>();
            CompanyRepresentatives = new HashSet<CompanyRepresentatives>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }

        public virtual ICollection<CompanyAddresses> CompanyAddresses { get; set; }
        public virtual ICollection<CompanyContactDetails> CompanyContactDetails { get; set; }
        public virtual ICollection<CompanyRepresentatives> CompanyRepresentatives { get; set; }
    }
}