using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.CurriculumVitaes
{
    public partial class QualificationLevels : BaseEntity
    {
        public QualificationLevels()
        {
            UserQualifications = new HashSet<UserQualifications>();
        }

        //public int QualificationLevelId { get; set; }
        public string QualificationLevel { get; set; }

        public virtual ICollection<UserQualifications> UserQualifications { get; set; }
    }
}