using System;
using System.Collections.Generic;

namespace DAtabasetables
{
    public partial class IntegratorUserInterests
    {
        public int IntegratorUserInterestId { get; set; }
        public int IntegratorUserId { get; set; }
        public int InterestId { get; set; }
        public double InterestLevel { get; set; }

        public virtual IntegratorUsers IntegratorUser { get; set; }
        public virtual Interests Interest { get; set; }
    }
}