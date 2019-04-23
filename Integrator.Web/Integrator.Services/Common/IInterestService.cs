using Integrator.Models.Domain.Common;
using Integrator.Models.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Integrator.Services.Common
{
    public interface IInterestService
    {
        #region Select Methods
        List<Interest> ListInterests();

        #endregion
        IEntityCRUDResponse AddInterest(Interest entity);

        IEntityCRUDResponse UpdateInterest(Interest entity);
    }
}
