using Integrator.Models.Domain.CurriculumVitaes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Integrator.Services.Common
{
    public partial interface IQualificationService
    {

        List<QualificationLevels> ListQualificationLevels();
    }
}
