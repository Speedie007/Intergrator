using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integrator.Data.Interfaces;
using Integrator.Models.Domain.CurriculumVitaes;
using Integrator.Models.ViewModels.Common;

namespace Integrator.Services.Common
{
    public partial class LanguageService : ILanguageService
    {

        #region Fields
        private readonly IRepository<LanguageList> _languageRepository;
        #endregion

        #region Cstor
        public LanguageService(IRepository<LanguageList> languageRepository)
        {
            this._languageRepository = languageRepository;
        }
        #endregion


        public List<LanguageList> ListLanguages()
        {
            var query = _languageRepository.Table;

            return query.ToList();
        }
    }
}
