using Integrator.Common;
using Integrator.Data.Interfaces;
using Integrator.Models.Domain.Companies;
using Integrator.Services.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integrator.Services.Companies
{
    public partial class CompanyService : ICompanyService
    {
        #region Fields
        private readonly IRepository<Company> _companyRepository;


        #endregion

        #region Cstor
        public CompanyService(IRepository<Company> companyRepository)
        {
            this._companyRepository = companyRepository;
        }
        #endregion
        public void AddCompany(Company Entity)
        {
            try
            {
                _companyRepository.Insert(Entity);
            }
            catch (IntegratorException e)
            {
                throw e;
            }

        }

        public Company GetCompany(int CompanyID)
        {

            try
            {
                return _companyRepository.GetById(CompanyID);
            }
            catch (IntegratorException e)
            {
                throw e;
            }

        }

        public List<Company> ListCompanies()
        {
            try
            {
                return _companyRepository.Table.ToList();
            }
            catch (IntegratorException e)
            {
                throw e;
            }
        }

        public void UpdateCompany(Company Entity)
        {
            try
            {
                _companyRepository.Update(Entity);
            }
            catch (IntegratorException e)
            {
                throw e;
            }
        }
    }
}
