using Integrator.Models.ViewModels.ViewModelBaseComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.ViewModels.Common
{
    public partial class UserContactDetailViewModel : BaseIntegratorEntityModel
    {

        public string ContactDetailValue { get; set; }
        public string ContactDetailType { get; set; }
        public DateTime DateLastUpdated { get; set; }

    }

    public enum ContactDetailTypes
    {
        Email,
        WebSite,
        CellNumber,
        OfficeNumber
    }
}
