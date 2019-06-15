using System;
using System.Collections.Generic;

namespace DAtabasetables
{
    public partial class CompanyContactDetails
    {
        public int CompanyContactDetailId { get; set; }
        public int ContactDetailId { get; set; }
        public int CompanyId { get; set; }

        public virtual Companies Company { get; set; }
        public virtual ContactDetails ContactDetail { get; set; }
    }
}