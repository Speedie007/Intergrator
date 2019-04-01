using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.CurriculumVitaes
{
    public partial class EductaionalInstitutions : BaseEntity
    {
        public EductaionalInstitutions()
        {
            UserQualifications = new HashSet<UserQualifications>();
        }

        //public int EductaionalInstitutionId { get; set; }
        public string EductaionalInstitution { get; set; }

        public virtual ICollection<UserQualifications> UserQualifications { get; set; }
    }
}