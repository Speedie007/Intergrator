using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integrator.Data.Interfaces;
using Integrator.Models.Domain.CurriculumVitaes;
using Integrator.Models.ViewModels.Common;
using Microsoft.EntityFrameworkCore;

namespace Integrator.Services.Common
{
    public partial class EducationInstitutionService : IEducationInstitutionService
    {

        #region Fields
        private readonly IRepository<EductaionalInstitutions> _eductaionalInstitutionsRepository;
        private readonly IEntityCRUDResponse _entityCRUDResponse;
        #endregion

        #region Cstor

        public EducationInstitutionService(
            IRepository<EductaionalInstitutions> eductaionalInstitutionsRepository,
            IEntityCRUDResponse entityCRUDResponse
            )
        {
            this._eductaionalInstitutionsRepository = eductaionalInstitutionsRepository;
            this._entityCRUDResponse = entityCRUDResponse;
        }
        #endregion


        public IEntityCRUDResponse AddEducationInstitution(EductaionalInstitutions entity)
        {

            try
            {
                 _eductaionalInstitutionsRepository.Insert(entity);
                _entityCRUDResponse.Success = true;
                _entityCRUDResponse.Message = "Educational Institution Successfully Added";
                _entityCRUDResponse.Returned_ID = entity.Id;
            }
            catch (Exception e)
            {
                _entityCRUDResponse.Success = false;
                _entityCRUDResponse.Message = "Educational Institution Was Not Successfully Added";
                _entityCRUDResponse.Returned_ID = 0;
            }

            return _entityCRUDResponse;
        }

        public  List<EductaionalInstitutions> ListEductaionalInstitutions()
        {
            var query = _eductaionalInstitutionsRepository.Table;

            return  query.ToList();
        }

        public  IEntityCRUDResponse UpdateEducationInstitution(EductaionalInstitutions entity)
        {
            try
            {
                 _eductaionalInstitutionsRepository.Update(entity);
                _entityCRUDResponse.Success = true;
                _entityCRUDResponse.Message = "Educational Institution Successfully Updated";
                _entityCRUDResponse.Returned_ID = entity.Id;
            }
            catch (Exception e)
            {
                _entityCRUDResponse.Success = false;
                _entityCRUDResponse.Message = "Educational Institution Was Not Successfully Updated";
                _entityCRUDResponse.Returned_ID = 0;
            }

            return _entityCRUDResponse;
        }

    }
}
