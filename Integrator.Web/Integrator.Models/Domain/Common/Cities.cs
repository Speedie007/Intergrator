using Integrator.Models.Domain.Addresses;
using Integrator.Models.Domain.Common;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.Common
{
    public partial class City: BaseEntity
    {
        public City()
        {
            Suburbs = new HashSet<Suburb>();
            Addresses = new HashSet<Address>();
            
        }

        
        public int CountryID { get; set; }
        public string CityName { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Suburb> Suburbs { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}