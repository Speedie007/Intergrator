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
    public partial class QualificationService : IQualificationService
    {
        #region Fields
        private readonly IRepository<QualificationLevels> _qualificationLevelsRepository;
        private readonly IEntityCRUDResponse _entityCRUDResponse;
        #endregion

        #region Cstor
        public QualificationService(
             IRepository<QualificationLevels> qualificationLevelsRepository,
             IEntityCRUDResponse entityCRUDResponse
            )
        {
            this._entityCRUDResponse = entityCRUDResponse;
            this._qualificationLevelsRepository = qualificationLevelsRepository;
        }
        #endregion
        public List<QualificationLevels> ListQualificationLevels()
        {
            var query = _qualificationLevelsRepository.Table;

            return  query.ToList();
        }
    }
}
