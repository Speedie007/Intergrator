using Integrator.Models.Domain.CurriculumVitaes;
using Integrator.Models.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Services.Common
{
    public interface IEducationInstitutionService
    {
        IEntityCRUDResponse AddEducationInstitution(EductaionalInstitutions entity);

        IEntityCRUDResponse UpdateEducationInstitution(EductaionalInstitutions entity);

        List<EductaionalInstitutions> ListEductaionalInstitutions();
    }
}
