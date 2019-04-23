using System;
using System.Collections.Generic;
using System.Text;
using Integrator.Models.Domain.Companies;

namespace Integrator.Services.Companies
{
    public interface ICompanyService
    {
        #region Seclect Moethods
        List<Company> ListCompanies();
        Company GetCompany(int CompanyID);
        #endregion

        #region Insert Methods
        void AddCompany(Company Entity);
        #endregion

        #region update Methods
        void UpdateCompany(Company Entity);
        #endregion

    }
}
