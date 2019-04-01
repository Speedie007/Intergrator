using Integrator.Models.Domain.CurriculumVitaes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.Common
{
    public partial class ContactDetails : BaseEntity
    {
        public ContactDetails()
        {
            IntegratorUserContactDetails = new HashSet<IntegratorUserContactDetails>();
            WorkExperienceReferenceContactDetails = new HashSet<WorkExperienceReferenceContactDetails>();
        }

        //[Key]
        //public int ContactDetailID { get; set; }
        public int ContactDetailTypeID { get; set; }
        [Required]
        [StringLength(200)]
        public string ContactItem { get; set; }

        public virtual ContactDetailTypes ContactDetailType { get; set; }
        public virtual ICollection<IntegratorUserContactDetails> IntegratorUserContactDetails { get; set; }
        public virtual ICollection<WorkExperienceReferenceContactDetails> WorkExperienceReferenceContactDetails { get; set; }
    }
}