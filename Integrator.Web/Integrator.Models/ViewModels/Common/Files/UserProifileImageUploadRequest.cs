using Integrator.Models.ViewModels.ViewModelBaseComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.ViewModels.Common.Files
{
    public class UserProifileImageUploadRequest : BaseIntegratorViewModel
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string ImageData { get; set; }
    }
}