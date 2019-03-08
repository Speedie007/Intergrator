using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.ViewModels.ViewModelBaseComponents
{
    class BaseIntegratorEntityModel : BaseIntegratorModel
    {
        /// <summary>
        /// Gets or sets model identifier
        /// </summary>
        public virtual int Id { get; set; }
    }
}