using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.Common
{
    public partial class ContactDetailType : BaseEntity
    {
        public ContactDetailType()
        {
            ContactDetails = new HashSet<ContactDetail>();
        }

        //[Key]
        //public int ContactDetailTypeID { get; set; }
        [Required]
        [StringLength(100)]
        public string aContactDetailType { get; set; }

        public virtual ICollection<ContactDetail> ContactDetails { get; set; }
    }
}