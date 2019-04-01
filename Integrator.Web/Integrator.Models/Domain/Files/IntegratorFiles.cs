using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.Files
{
    public partial class IntegratorFiles : BaseEntity
    {
        public IntegratorFiles()
        {
            UserFiles = new HashSet<UserFiles>();
            UserPictures = new HashSet<UserPictures>();
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
        public int FileSize { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }

        public string FileFullName => $"{FileName}.{FileExtension}";

        public virtual ICollection<UserFiles> UserFiles { get; set; }
        public virtual ICollection<UserPictures> UserPictures { get; set; }
        public virtual InegratorFileBlobs InegratorFileBlob { get; set; }
    }
}