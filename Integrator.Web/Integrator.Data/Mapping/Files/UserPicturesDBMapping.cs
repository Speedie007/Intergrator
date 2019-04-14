using Integrator.Models.Domain.Files;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Files
{
    class UserPicturesDbMapping : IntegratorEntityTypeConfiguration<UserPicture>
    {
        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<UserPicture> builder)
        {
            builder.ToTable("UserPictures")
                .Property(x => x.Id).HasColumnName("FileID")
                 .ValueGeneratedNever();

            builder.HasKey(e => e.Id);
                


           
                 
            builder.HasOne(d => d.IntegratorFile)
               .WithOne(p => p.UserPicture)
               .HasForeignKey<UserPicture>(d => d.Id)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_UserPictures_IntegratorFiles");

            builder.HasOne(d => d.IntegratorUser)
                .WithMany(p => p.UserPicture)
                .HasForeignKey(d => d.IntegratorUserID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_UserPicture_Users");

            base.Configure(builder);
        }
    }
}
