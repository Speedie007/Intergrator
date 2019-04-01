using Integrator.Models.ViewModels.ViewModelBaseComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Integrator.Models.ViewModels.Common.Files
{
    public partial class FileViewModel : BaseIntegratorEntityModel
    {
        [Display(Name ="Content Type")]
        public string ContentType { get; set; }
        [Display(Name = "Name")]
        public string FileName { get; set; }
        [Display(Name = "Extension")]
        public string FileExtension { get; set; }
        [Display(Name = "Size")]
        public string FileSize { get; set; }
        [Display(Name = "Date Created")]
        public string DateCreated { get; set; }
        public byte[] FileBytes { get; set; }
    }
}
