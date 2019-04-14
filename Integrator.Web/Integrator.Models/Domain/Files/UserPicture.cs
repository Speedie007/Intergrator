using Integrator.Models.Domain.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.Files
{
    public partial class UserPicture : BaseEntity
    {
        
        public int IntegratorUserID { get; set; }
       
        

        public Boolean IsCurrentProfilePicture { get; set; }

        public virtual IntegratorFile IntegratorFile { get; set; }
        public virtual IntegratorUser IntegratorUser { get; set; }

               
    }
}