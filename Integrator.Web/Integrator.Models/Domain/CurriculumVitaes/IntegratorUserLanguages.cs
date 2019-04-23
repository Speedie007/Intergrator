using Integrator.Models.Domain.Authentication;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.CurriculumVitaes
{
    public partial class IntegratorUserLanguages : BaseEntity
    {
        //public int IntegratorUserLanguageId { get; set; }
        public int IntegratorUserID { get; set; }
        public int LanguageID { get; set; }
        public bool IsPrimaryLanguage { get; set; }
        public bool CanSpeakAndWrite { get; set; }
        public double LanguageProficiencyLevel { get; set; }

        public virtual IntegratorUser IntegratorUser { get; set; }
        public virtual Language SpokenLanguage { get; set; }
    }
}