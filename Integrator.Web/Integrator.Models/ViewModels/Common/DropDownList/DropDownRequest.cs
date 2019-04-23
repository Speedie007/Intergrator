using Integrator.Models.ViewModels.ViewModelBaseComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.ViewModels.Common.DropDownList
{
    public partial class DropDownRequest: BaseIntegratorViewModel
    {
        public int ID { get; set; }
        public string TEXT { get; set; }
    }
}
