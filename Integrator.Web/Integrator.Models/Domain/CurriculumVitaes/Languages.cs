using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.CurriculumVitaes
{
    public partial class Language : BaseEntity
    {
        public Language()
        {
            UserLanguages = new HashSet<IntegratorUserLanguages>();
        }

        public string LanguageSpoken { get; set; }

        public virtual ICollection<IntegratorUserLanguages> UserLanguages { get; set; }
    }

    public class LanguageComparer : IEqualityComparer<Language>
    {
        public bool Equals(Language x, Language y)
        {
            if (x.Id == y.Id && x.LanguageSpoken.ToLower() == y.LanguageSpoken.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(Language obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}