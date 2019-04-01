using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.Files
{
    public partial class InegratorFileBlobs: BaseEntity
    {
        
        public byte[] FileBlob { get; set; }

        public virtual IntegratorFiles IntegratorFile { get; set; }
    }
}