using Integrator.Models.Domain.Common;
using Integrator.Models.Domain.CurriculumVitaes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.Common
{
    public partial class Interest : BaseEntity
    {
        public Interest()
        {
            IntegratorUserInterests = new HashSet<IntegratorUserInterest>();
        }


        public string AnInterest { get; set; }
        

        public virtual ICollection<IntegratorUserInterest> IntegratorUserInterests { get; set; }
    }
}

public class InterestComparer : IEqualityComparer<Interest>
{
    public bool Equals(Interest x, Interest y)
    {
        if (x.Id == y.Id && x.AnInterest.ToLower() == y.AnInterest.ToLower())
            return true;

        return false;
    }

    public int GetHashCode(Interest obj)
    {
        return obj.Id.GetHashCode();
    }
}