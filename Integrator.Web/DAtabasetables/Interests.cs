using System;
using System.Collections.Generic;

namespace DAtabasetables
{
    public partial class Interests
    {
        public Interests()
        {
            IntegratorUserInterests = new HashSet<IntegratorUserInterests>();
        }

        public int InterestId { get; set; }
        public string Interest { get; set; }

        public virtual ICollection<IntegratorUserInterests> IntegratorUserInterests { get; set; }
    }
}