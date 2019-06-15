using System;
using System.Collections.Generic;

namespace DAtabasetables
{
    public partial class CompanyRepresentatives
    {
        public int CompanyRepresentativeId { get; set; }
        public int IntegratorUserId { get; set; }
        public int CompanyId { get; set; }

        public virtual Companies Company { get; set; }
        public virtual IntegratorUsers IntegratorUser { get; set; }
    }
}