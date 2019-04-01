using Integrator.Models.Interfaces;
using Integrator.Models.ViewModels.ViewModelBaseComponents;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Integrator.Models.ViewModels.Common.Addresses
{
    public partial class POBoxAddressViewModel : BaseIntegratorEntityModel, IAddress
    {
        public POBoxAddressViewModel()
        {
            Counties = new List<SelectListItem>();
        }

        

        [Required]
        [Display(Name = "P.O Box Number")]
        public virtual string POBoxNumber { get; set; }

        [Required]
        public virtual string City { get; set; }

        [Required]
        public virtual string Suburb { get; set; }

        [Required]
        [Display(Name = "Area Code")]
        public virtual string AreaCode { get; set; }

        public virtual List<SelectListItem> Counties { get; set; }
    }
}
