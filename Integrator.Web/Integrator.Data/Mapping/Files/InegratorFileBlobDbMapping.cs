using Integrator.Models.Domain.Files;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Files
{
    public partial class InegratorFileBlobDbMapping : IntegratorEntityTypeConfiguration<InegratorFileBlobs>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<InegratorFileBlobs> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("FileID")
                .ValueGeneratedNever(); 



            builder.Property(e => e.FileBlob)
                .IsRequired()
                .HasColumnType("image");

            builder.HasOne(d => d.IntegratorFile)
                .WithOne(p => p.InegratorFileBlob)
                .HasForeignKey<InegratorFileBlobs>(d => d.Id)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_InegratorFileBlobs_IntegratorFiles");


            base.Configure(builder);
        }
    }
}