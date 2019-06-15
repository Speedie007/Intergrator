using System;
using System.Collections.Generic;

namespace DAtabasetables
{
    public partial class ContactDetails
    {
        public ContactDetails()
        {
            CompanyContactDetails = new HashSet<CompanyContactDetails>();
        }

        public int ContactDetailId { get; set; }
        public int ContactDetailTypeId { get; set; }
        public string ContactItem { get; set; }

        public virtual ICollection<CompanyContactDetails> CompanyContactDetails { get; set; }
    }
}