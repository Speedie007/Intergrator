using System;
using System.Collections.Generic;

namespace DAtabasetables
{
    public partial class InegratorFileBlobs
    {
        public int FileId { get; set; }
        public byte[] FileBlob { get; set; }

        public virtual IntegratorFiles File { get; set; }
    }
}