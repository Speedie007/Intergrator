using Integrator.Models.Domain.CurriculumVitaes;
using Integrator.Models.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Services.Common
{
    public interface ILanguageService
    {
        List<LanguageList> ListLanguages();

        
    }
}
