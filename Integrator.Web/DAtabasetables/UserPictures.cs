using System;
using System.Collections.Generic;

namespace DAtabasetables
{
    public partial class UserPictures
    {
        public int FileId { get; set; }
        public int IntegratorUserId { get; set; }
        public bool IsCurrentProfilePicture { get; set; }

        public virtual IntegratorFiles File { get; set; }
        public virtual IntegratorUsers IntegratorUser { get; set; }
    }
}