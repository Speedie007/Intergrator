using Integrator.Models.Interfaces;
using Integrator.Models.ViewModels.ViewModelBaseComponents;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Integrator.Models.ViewModels.Common.Addresses
{
    public partial class ComplexAddressViewModel : BaseIntegratorEntityModel, IAddress
    {
        public ComplexAddressViewModel()
        {
            Counties = new List<SelectListItem>();
        }

       
        [Required]
        [Display(Name = "Complex Name")]
        public virtual string ComplexName { get; set; }
        [Required]
        [Display(Name = "Unit Number")]
        public virtual string ComplexUnitNumber { get; set; }
        
        [Required]
        [Display(Name ="City/Town")]
        public virtual string City { get; set; }
        public virtual string Suburb { get; set; }
        [Required]
        [Display(Name = "Area Code")]
        public virtual string AreaCode { get; set; }

        public virtual List<SelectListItem> Counties { get; set; }
    }
}
