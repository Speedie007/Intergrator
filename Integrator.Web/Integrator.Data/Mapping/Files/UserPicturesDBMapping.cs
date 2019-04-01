using Integrator.Models.Domain.Files;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Files
{
    class UserPicturesDbMapping : IntegratorEntityTypeConfiguration<UserPictures>
    {
        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<UserPictures> builder)
        {
            builder.ToTable("UserPictures")
                .Property(x => x.Id).HasColumnName("PictureID");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.DateLastUpdated).HasColumnType("datetime");


            builder.HasOne(d => d.IntegratorFile)
                .WithMany(p => p.UserPictures)
                .HasForeignKey(d => d.FilesID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_UserPicture_IntegratorFiles");

            builder.HasOne(d => d.IntegratorUser)
                .WithMany(p => p.UserPicture)
                .HasForeignKey(d => d.IntegratorUserID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_UserPicture_Users");

            base.Configure(builder);
        }
    }
}
