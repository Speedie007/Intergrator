using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.Files
{
    public partial class InegratorFileBlob: BaseEntity
    {
        
        public byte[] FileBlob { get; set; }

        public virtual IntegratorFile IntegratorFile { get; set; }
    }
}