using Integrator.Models.Domain.CurriculumVitaes;
using Integrator.Models.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Integrator.Services.Common
{
    public interface ILanguageService
    {
        List<Language> ListLanguages();
        Task <List<Language>> ListLanguagesAsync();


    }
}
