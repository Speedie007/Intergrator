using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.CurriculumVitaes
{
    public partial class LanguageList : BaseEntity
    {
        public LanguageList()
        {
            IntegratorUserLanguages = new HashSet<IntegratorUserLanguages>();
        }

        //public int LanguageId { get; set; }
        public string Language { get; set; }

        public virtual ICollection<IntegratorUserLanguages> IntegratorUserLanguages { get; set; }
    }
}