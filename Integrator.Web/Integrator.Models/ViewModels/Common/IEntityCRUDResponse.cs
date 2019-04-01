using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.ViewModels.Common
{
    public interface IEntityCRUDResponse
    {
        int Returned_ID { get; set; }
        string Message { get; set; }
        Boolean Success { get; set; }
    }
}
