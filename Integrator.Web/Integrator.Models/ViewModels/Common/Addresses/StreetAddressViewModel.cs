using Integrator.Models.Interfaces;
using Integrator.Models.ViewModels.ViewModelBaseComponents;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Integrator.Models.ViewModels.Common.Addresses
{
    public partial class StreetAddressViewModel : BaseIntegratorEntityModel, IAddress
    {

        public StreetAddressViewModel()
        {
            Counties = new List<SelectListItem>();
        }
        
        [Required]
        [Display(Name = "Number")]
        public virtual string StreetNumber { get; set; }

        [Required]
        [Display(Name = "Street")]
        public virtual string StreetName { get; set; }

        [Required]
        public virtual string City { get; set; }

        [Required]
        public virtual string Suburb { get; set; }

        [Required]
        [Display(Name = "Area Code")]
        public virtual string AreaCode { get; set; }

        // public List<SelectListItem> UserRoles { get; set; }
        public virtual List<SelectListItem> Counties { get; set; }
    }
}
