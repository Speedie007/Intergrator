using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.ViewModels.Users
{
    public partial class EditUserAwardViewModel : UserAwardViewModel
    {


        public EditUserAwardViewModel()
        {
            UserAwards = new List<UserAwardViewModel>();
        }

        public List<UserAwardViewModel> UserAwards { get; set; }
    }
}
