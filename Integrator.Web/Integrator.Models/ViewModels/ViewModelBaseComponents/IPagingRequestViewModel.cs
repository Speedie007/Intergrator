using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.ViewModels.ViewModelBaseComponents
{
    /// <summary>
    /// Represents a paging request model
    /// </summary>
    public partial interface IPagingRequestViewModel
    {
        /// <summary>
        /// Gets or sets a page number
        /// </summary>
        int Page { get; set; }

        /// <summary>
        /// Gets or sets a page size
        /// </summary>
        int PageSize { get; set; }
    }
}