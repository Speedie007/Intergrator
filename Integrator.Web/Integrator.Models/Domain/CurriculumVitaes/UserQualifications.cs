using Integrator.Models.Domain.Authentication;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.CurriculumVitaes
{
    public partial class UserQualification : BaseEntity
    {
        //public int UserQualificationID { get; set; }
        public int IntegratorUserID { get; set; }
        public int EductaionalInstitutionID { get; set; }
        public int QualificationLevelID { get; set; }
        public string QualificationTitle { get; set; }
        public DateTime YearStartedQualification { get; set; }
        public DateTime YearCompletedQualification { get; set; }
        public double QualificationAverage { get; set; }


        public virtual EductaionalInstitutions EductaionalInstitution { get; set; }
        public virtual IntegratorUser IntegratorUser { get; set; }
        public virtual QualificationLevels QualificationLevel { get; set; }
    }
}