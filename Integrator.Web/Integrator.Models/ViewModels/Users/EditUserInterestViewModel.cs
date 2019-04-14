using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Integrator.Models.ViewModels.Users
{
    public partial class EditUserInterestViewModel : UserInterestViewModel
    {

        public EditUserInterestViewModel()
        {
            Interests = new List<SelectListItem>();
            UserInterests = new List<UserInterestViewModel>();
        }


        public virtual int InterestID { get; set; }

        [Display(Name = "Qualifications")]
        public List<SelectListItem> Interests { get; set; }

        public List<UserInterestViewModel> UserInterests { get; set; }
    }
}
