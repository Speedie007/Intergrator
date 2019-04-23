using Integrator.Models.ViewModels.Administration.Membership;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Factories.Administration
{
    public partial interface IAdministrationViewModelFactory
    {

        SystemUserViewModel PrepareAdministrationSystemUserViewModel();
    }
}
