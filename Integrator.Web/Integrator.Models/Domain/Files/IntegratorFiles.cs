using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.Files
{
    public partial class IntegratorFile : BaseEntity
    {
        public IntegratorFile()
        {
            UserFiles = new HashSet<UserFile>();
            
        }

        
        [Required]
        [StringLength(100)]
        public string ContentType { get; set; }
        [Required]
        [StringLength(200)]
        public string FileName { get; set; }
        [Required]
        [StringLength(25)]
        public string FileExtension { get; set; }

        public Int64 FileSize { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }

        public string FileFullName => $"{FileName}.{FileExtension}";

        public virtual ICollection<UserFile> UserFiles { get; set; }
       
        public virtual InegratorFileBlob InegratorFileBlob { get; set; }

        public virtual UserPicture UserPicture { get; set; }
    }
}