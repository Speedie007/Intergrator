using Integrator.Models.Domain.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.Files
{
    public partial class UserPictures : BaseEntity
    {
        
        public int IntegratorUserID { get; set; }
        public int FilesID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateLastUpdated { get; set; }

        public virtual IntegratorFiles IntegratorFile { get; set; }
        public virtual IntegratorUser IntegratorUser { get; set; }
    }
}