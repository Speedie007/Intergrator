using Integrator.Models.Domain.Authentication;
using Integrator.Models.ViewModels.ViewModelBaseComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.ViewModels.Administration.Membership
{
    public partial class SystemUserViewModel : BaseIntegratorViewModel
    {


        #region Cstor
        public SystemUserViewModel()
        {
            ListOfAgents = new List<IntegratorUser>();
            ListOfListSystemUsers = new List<IntegratorUser>();
        }
        #endregion

        #region Properties
        public List<IntegratorUser> ListOfAgents { get; set; }
        public List<IntegratorUser> ListOfListSystemUsers { get; set; }
        #endregion

    }
}
