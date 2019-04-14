using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.CurriculumVitaes
{
    public partial class EductaionalInstitutions : BaseEntity
    {
        public EductaionalInstitutions()
        {
            UserQualifications = new HashSet<UserQualification>();
        }

        //public int EductaionalInstitutionId { get; set; }
        public string EductaionalInstitution { get; set; }

        public virtual ICollection<UserQualification> UserQualifications { get; set; }
    }
}