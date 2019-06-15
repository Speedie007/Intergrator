using System;
using System.Collections.Generic;

namespace DAtabasetables
{
    public partial class CompanyAddresses
    {
        public int CompanyAddressId { get; set; }
        public int AddressId { get; set; }
        public int CompanyId { get; set; }

        public virtual Addresses Address { get; set; }
        public virtual Companies Company { get; set; }
    }
}