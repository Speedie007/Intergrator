using Integrator.Models;
using Integrator.Models.Domain.Addresses;
using Integrator.Models.Domain.Companies;
using Integrator.Models.Domain.KnowledgeBase.Companies;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.Companies
{
    public partial class CompanyBranch:BaseEntity
    {
        public CompanyBranch()
        {
            CompanyContactDetails = new HashSet<CompanyContactDetail>();
            CompanyRepresentiveBranches = new HashSet<CompanyRepresentiveBranch>();
            //CompanyJobs = new HashSet<CompanyJob>();
            //CompanyRelatedIndustries = new HashSet<CompanyRelatedIndustry>();
            CompanyJobAssociatedBranches = new HashSet<CompanyJobAssociatedBranch>();
            CompanyBranchAddresses = new HashSet<CompanyBranchAddress>();
        }
        //public int AddressID { get; set; }
        public int CompanyID { get; set; }
        public String BranchDescription { get; set; }

        public virtual Company Company { get; set; }
        
        public virtual ICollection<CompanyContactDetail> CompanyContactDetails { get; set; }
        public virtual ICollection<CompanyRepresentiveBranch> CompanyRepresentiveBranches { get; set; }

        //public virtual ICollection<CompanyJob> CompanyJobs { get; set; }
        // public virtual ICollection<CompanyRelatedIndustry> CompanyRelatedIndustries { get; set; }
        public virtual ICollection<CompanyJobAssociatedBranch> CompanyJobAssociatedBranches { get; set; }
        public virtual ICollection<CompanyBranchAddress> CompanyBranchAddresses { get; set; }
    }
}