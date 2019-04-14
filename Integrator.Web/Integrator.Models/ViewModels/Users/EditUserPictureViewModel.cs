using Integrator.Models.ViewModels.Common.Files;
using Integrator.Models.ViewModels.ViewModelBaseComponents;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.ViewModels.Users
{
    public partial class EditUserPictureViewModel : FileViewModel
    {

        public EditUserPictureViewModel()
        {
            UserProfileImages = new List<FileViewModel>();
        }

        public int sourceX { get; set; }
        public int sourceY { get; set; }
        public int sourceWidth { get; set; }
        public int sourceHeight { get; set; }

        public int DefaultPictureID { get; set; }

        public IFormFile UserProfileImage { get; set; }

        public List<FileViewModel> UserProfileImages { get; set; }
    }
}
