using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.ViewModels.ViewModelBaseComponents
{
    public partial class BaseIntegratorEntityModel : BaseIntegratorViewModel
    {
        /// <summary>
        /// Gets or sets model identifier
        /// </summary>
        public virtual int Id { get; set; }
    }
}