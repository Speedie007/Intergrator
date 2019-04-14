using Integrator.Models.Domain.CurriculumVitaes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.Common
{
    public partial class ContactDetail : BaseEntity
    {
        public ContactDetail()
        {
            IntegratorUserContactDetails = new HashSet<IntegratorUserContactDetail>();
            WorkExperienceReferenceContactDetails = new HashSet<WorkExperienceReferenceContactDetail>();
        }

        
        public int ContactDetailTypeID { get; set; }
        [Required]
        [StringLength(200)]
        public string ContactItem { get; set; }

        public virtual ContactDetailType ContactDetailType { get; set; }
        public virtual ICollection<IntegratorUserContactDetail> IntegratorUserContactDetails { get; set; }
        public virtual ICollection<WorkExperienceReferenceContactDetail> WorkExperienceReferenceContactDetails { get; set; }
    }
}