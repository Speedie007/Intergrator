using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.CurriculumVitaes
{
    public partial class LanguageList : BaseEntity
    {
        public LanguageList()
        {
            UserLanguages = new HashSet<IntegratorUserLanguages>();
        }

        public string Language { get; set; }

        public virtual ICollection<IntegratorUserLanguages> UserLanguages { get; set; }
    }

    public class LanguageComparer : IEqualityComparer<LanguageList>
    {
        public bool Equals(LanguageList x, LanguageList y)
        {
            if (x.Id == y.Id && x.Language.ToLower() == y.Language.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(LanguageList obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}