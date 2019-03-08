using Integrator.Common.Engine;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.ViewModels.ViewModelBaseComponents
{
    class BaseSearchViewModel : BaseIntegratorViewModel, IPagingRequestViewModel
    {
        #region Ctor

        public BaseSearchViewModel()
        {
            //set the default values
            this.Page = 1;
            this.PageSize = 10;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets a page number
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets a page size
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets a comma-separated list of available page sizes
        /// </summary>
        public string AvailablePageSizes { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Set grid page parameters
        /// </summary>
        public void SetGridPageSize()
        {
            //var adminAreaSettings = EngineContext.Current.Resolve<AdminAreaSettings>();

            this.Page = 1;
            this.PageSize = 5;// adminAreaSettings.DefaultGridPageSize;
            this.AvailablePageSizes = "5";// adminAreaSettings.GridPageSizes;
        }

        /// <summary>
        /// Set popup grid page parameters
        /// </summary>
        public void SetPopupGridPageSize()
        {
           // var adminAreaSettings = EngineContext.Current.Resolve<AdminAreaSettings>();

            this.Page = 1;
            this.PageSize = 5;// adminAreaSettings.PopupGridPageSize;
            this.AvailablePageSizes = "5";// adminAreaSettings.GridPageSizes;
        }

        #endregion
    }
}