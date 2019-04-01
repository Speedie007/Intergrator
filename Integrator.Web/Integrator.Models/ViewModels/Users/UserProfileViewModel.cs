using Integrator.Models.Interfaces;
using Integrator.Models.ViewModels.ViewModelBaseComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Integrator.Models.ViewModels.Users
{
    public partial class UserProfileViewModel : BaseIntegratorViewModel
    {

        public UserProfileViewModel()
        {
            Address = new List<IAddress>();
        }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "ID Number")]
        public string UserIDNumber { get; set; }

        public byte[] UserPicture { get; set; }

        public List<IAddress> Address { get; set; }

        

    }
}
