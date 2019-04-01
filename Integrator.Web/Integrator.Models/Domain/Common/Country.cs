using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.Domain.Common
{
    public class Country : BaseEntity
    {
        /// <summary>
        /// get or set country Name
        /// </summary>
        public string CountryName { get; set; }
        /// <summary>
        /// get or set country code
        /// </summary>
        public string CountryCode { get; set; }

    }
}
