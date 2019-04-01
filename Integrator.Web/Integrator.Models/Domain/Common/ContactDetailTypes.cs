using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.Common
{
    public partial class ContactDetailTypes : BaseEntity
    {
        public ContactDetailTypes()
        {
            ContactDetails = new HashSet<ContactDetails>();
        }

        //[Key]
        //public int ContactDetailTypeID { get; set; }
        [Required]
        [StringLength(100)]
        public string ContactDetailType { get; set; }

        public virtual ICollection<ContactDetails> ContactDetails { get; set; }
    }
}