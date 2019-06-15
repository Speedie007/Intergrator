﻿using System;
using System.Collections.Generic;

namespace DAtabasetables
{
    public partial class CompanyRepresentatives
    {
        public CompanyRepresentatives()
        {
            CompanyJobRepresentitives = new HashSet<CompanyJobRepresentitives>();
            CompanyRelatedIndustryRepresentives = new HashSet<CompanyRelatedIndustryRepresentives>();
        }

        public int CompanyRepresentativeId { get; set; }
        public int IntegratorUserId { get; set; }
        public int CompanyId { get; set; }

        public virtual ICollection<CompanyJobRepresentitives> CompanyJobRepresentitives { get; set; }
        public virtual ICollection<CompanyRelatedIndustryRepresentives> CompanyRelatedIndustryRepresentives { get; set; }
    }
}