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
    public partial class LanguageService : ILanguageService
    {

        #region Fields
        private readonly IRepository<Language> _languageRepository;
        #endregion

        #region Cstor
        public LanguageService(IRepository<Language> languageRepository)
        {
            this._languageRepository = languageRepository;
        }
        #endregion


        public List<Language> ListLanguages()
        {
            var query = _languageRepository.Table;

            return query.ToList();
        }

        public async Task<List<Language>> ListLanguagesAsync()
        {
            var query = _languageRepository.Table;

            return await query.ToListAsync();
        }
    }
}
