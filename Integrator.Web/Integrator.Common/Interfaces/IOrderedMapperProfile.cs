using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Common.Interfaces
{
    public interface IOrderedMapperProfile
    {
        /// <summary>
        /// Gets order of this configuration implementation
        /// </summary>
        int Order { get; }
    }
}
