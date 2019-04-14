using Integrator.Models.Domain.Files;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Files
{
    public partial class UserFilesDbMapping : IntegratorEntityTypeConfiguration<UserFile>
    {
        
        /// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<UserFile> builder)
        {
            builder.ToTable("UserFiles");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("UserFileID");


            builder.HasOne(d => d.IntegratorFile)
                .WithMany(p => p.UserFiles)
                .HasForeignKey(d => d.FileID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_UserFiles_IntegratorFiles");

            builder.HasOne(d => d.IntegratorUser)
                .WithMany(p => p.UserFiles)
                .HasForeignKey(d => d.IntegratorUserID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_UserFiles_Users");


            base.Configure(builder);
        }
    }
}