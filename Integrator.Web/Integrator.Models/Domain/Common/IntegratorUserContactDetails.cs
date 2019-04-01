using Integrator.Models.Domain.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.Common
{
    public partial class IntegratorUserContactDetails : BaseEntity
    {
        //[Key]
        //public int IntegratorUserContactDetailID { get; set; }
        public int IntegratorUserID { get; set; }
        public int ContactDetailID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateLastUpdated { get; set; }


        public virtual ContactDetails ContactDetail { get; set; }

        public virtual IntegratorUser IntegratorUser { get; set; }
    }
}