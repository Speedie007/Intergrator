using Integrator.Models.Domain.Addresses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.Domain.Common
{
    public class Country : BaseEntity
    {
        public Country()
        {
            Addresses = new HashSet<Address>();
            Cities = new HashSet<City>();
        }

      
        public string CountryName { get; set; }
        public string CountryCode { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<City> Cities { get; set; }

    }
}
