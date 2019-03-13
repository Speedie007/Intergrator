using Integrator.Models.Domain.Authentication;
using Integrator.Models.Domain.Common.Country;
using System;
using System.Collections.Generic;
using System.Text;
using Integrator.Models.Interfaces;

namespace Integrator.Models.Domain.Address
{
    public abstract partial class Address : BaseEntity, IAddress
    {

        public virtual string City { get; set; }
        public virtual string Suburb { get; set; }
        public virtual string AreaCode { get; set; }

        public virtual int IntegratorUserID { get; set; }
        public virtual int CountryID { get; set; }

        public virtual Country Country { get; set; }
        public virtual IntegratorUser IntegratorUser { get; set; }
    }

    public partial class POBoxAddress : Address, IAddress
    {
        public virtual string POBoxNumber { get; set; }
    }

    public partial class StreetAddress : Address, IAddress
    {
        public virtual string StreetNumber { get; set; }
        public virtual string StreetName { get; set; }
    }

    public partial class ComplexAddress : Address, IAddress
    {
        public virtual string ComplexName { get; set; }
        public virtual string ComplexUnitNumber { get; set; }
    }

    public enum AddressTypes
    {
        POBoxAddress, StreetAddress, ComplexAddress
    }

}
