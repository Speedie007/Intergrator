using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.ViewModels.ViewModelBaseComponents
{
    public abstract partial class BasePagedListViewModel<T> : BaseIntegratorViewModel, IPagedViewModel<T> where T : BaseIntegratorViewModel
    {
        /// <summary>
        /// Gets or sets data records
        /// </summary>
        public IEnumerable<T> Data { get; set; }

        /// <summary>
        /// Gets or sets total records number
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Gets or sets an extra data
        /// </summary>
        public object ExtraData { get; set; }

        /// <summary>
        /// Gets or sets an errors
        /// </summary>
        public object Errors { get; set; }
    }
}