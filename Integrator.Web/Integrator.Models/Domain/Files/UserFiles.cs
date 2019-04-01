﻿using Integrator.Models.Domain.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.Files
{
    public partial class UserFiles : BaseEntity
    {
        
        
        public int FileID { get; set; }
        public int IntegratorUserID { get; set; }

       
        public virtual IntegratorFiles IntegratorFile { get; set; }
       
        public virtual IntegratorUser IntegratorUser { get; set; }
    }
}