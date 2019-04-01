using System;
using System.Collections.Generic;

namespace DAtabasetables
{
    public partial class ContactDetails
    {
        public ContactDetails()
        {
            WorkExperienceReferenceContactDetails = new HashSet<WorkExperienceReferenceContactDetails>();
        }

        public int ContactDetailId { get; set; }
        public int ContactDetailTypeId { get; set; }
        public string ContactItem { get; set; }

        public virtual ICollection<WorkExperienceReferenceContactDetails> WorkExperienceReferenceContactDetails { get; set; }
    }
}