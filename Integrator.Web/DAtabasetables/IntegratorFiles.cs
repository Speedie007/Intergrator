using System;
using System.Collections.Generic;

namespace DAtabasetables
{
    public partial class IntegratorFiles
    {
        public IntegratorFiles()
        {
            UserFiles = new HashSet<UserFiles>();
        }

        public int FileId { get; set; }
        public string ContentType { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public long FileSize { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual InegratorFileBlobs InegratorFileBlobs { get; set; }
        public virtual UserPictures UserPictures { get; set; }
        public virtual ICollection<UserFiles> UserFiles { get; set; }
    }
}