using System;
using System.Collections.Generic;

namespace DAtabasetables
{
    public partial class Addresses
    {
        public Addresses()
        {
            CompanyAddresses = new HashSet<CompanyAddresses>();
        }

        public int AddressId { get; set; }
        public string City { get; set; }
        public string Suburb { get; set; }
        public string AreaCode { get; set; }
        public int IntegratorUserId { get; set; }
        public int CountryId { get; set; }
        public string Country { get; set; }
        public int AddressType { get; set; }
        public string ComplexName { get; set; }
        public string ComplexUnitNumber { get; set; }
        public string PoboxNumber { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }

        public virtual IntegratorUsers IntegratorUser { get; set; }
        public virtual ICollection<CompanyAddresses> CompanyAddresses { get; set; }
    }
}