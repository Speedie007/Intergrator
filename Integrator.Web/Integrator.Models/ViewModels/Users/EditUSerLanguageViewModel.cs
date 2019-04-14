using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.ViewModels.Users
{
    public partial class EditUserLanguageViewModel : UserLanguageViewModel
    {
        #region Cstor
        public EditUserLanguageViewModel()
        {
            ListOfLanguages = new List<SelectListItem>();
            ListOfUserLanguages = new List<UserLanguageViewModel>();
        }
        #endregion

        public int LanguageID { get; set; }
        public List<SelectListItem> ListOfLanguages { get; set; }

        public int UserLanguageID { get; set; }
        public List<UserLanguageViewModel> ListOfUserLanguages { get; set; }
    }
}
