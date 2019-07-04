using Integrator.Models.Domain.Authentication;
using Integrator.Models.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;
using Integrator.Models.Interfaces;
using Integrator.Models.Domain.Companies;
using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;

namespace Integrator.Models.Domain.Addresses
{
    public abstract partial class Address : BaseEntity, IAddress
    {
        public Address()
        {
            //CompanyBranches = new HashSet<CompanyBranch>();
            CustomerAddresses = new HashSet<IndividualAddress>();
            CompanyBranchAddresses = new HashSet<CompanyBranchAddress>();
        }
        public virtual int CountryID { get; set; }
        public int CityID { get; set; }
        public int SuburbID { get; set; }
        public virtual string AreaCode { get; set; }


        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual Suburb Suburb { get; set; }


        public virtual ICollection<CompanyBranchAddress> CompanyBranchAddresses { get; set; }

        public virtual ICollection<IndividualAddress> CustomerAddresses { get; set; }
    }

    public partial class POBoxAddress : Address
    {
        public virtual string POBoxNumber { get; set; }
    }

    public partial class StreetAddress : Address
    {
        public virtual string StreetNumber { get; set; }
        public virtual string StreetName { get; set; }
    }

    public partial class ComplexAddress : Address
    {
        public virtual string ComplexName { get; set; }
        public virtual string ComplexUnitNumber { get; set; }
    }

    public enum AddressTypes
    {
        POBoxAddress, StreetAddress, ComplexAddress
    }

}
