using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integrator.Data.Interfaces;
using Integrator.Models.Domain.Common;
using Integrator.Models.ViewModels.Common;
using Microsoft.EntityFrameworkCore;

namespace Integrator.Services.Common
{
    public partial class InterestService : IInterestService
    {

        #region Fields
        private readonly IRepository<Interest> _interestRepository;
        private readonly IEntityCRUDResponse _entityCRUDResponse;
        #endregion
        #region Cstor
        public InterestService(
            IRepository<Interest> interestRepository,
             IEntityCRUDResponse entityCRUDResponse
            )
        {
            this._entityCRUDResponse = entityCRUDResponse;
            this._interestRepository = interestRepository;
        }
        #endregion
        public IEntityCRUDResponse AddInterest(Interest entity)
        {
            try
            {
                _interestRepository.Insert(entity);
                _entityCRUDResponse.Success = true;
                _entityCRUDResponse.Message = "Interest Successfully Added";
                _entityCRUDResponse.Returned_ID = entity.Id;
            }
            catch (Exception e)
            {
                _entityCRUDResponse.Success = false;
                _entityCRUDResponse.Message = "Interest Was Not Successfully Added";
                _entityCRUDResponse.Returned_ID = 0;
            }

            return _entityCRUDResponse;
        }
        public List<Interest> ListInterests()
        {
            var query = _interestRepository.Table;

            return query.ToList();
        }

        public IEntityCRUDResponse UpdateInterest(Interest entity)
        {
            throw new NotImplementedException();
        }
    }
}
