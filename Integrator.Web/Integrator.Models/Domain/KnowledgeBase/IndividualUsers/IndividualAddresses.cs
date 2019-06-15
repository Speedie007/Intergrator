using Integrator.Models.Domain.Addresses;
using Integrator.Models.Domain.Authentication;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.Domain.KnowledgeBase.IndividualUsers
{
    public partial class IndividualAddress: BaseEntity
    {
        public int AddressID { get; set; }
        public int IntegratorUserID { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual Address Address { get; set; }
        public virtual IntegratorUser IntegratorUser { get; set; }
    }
}
