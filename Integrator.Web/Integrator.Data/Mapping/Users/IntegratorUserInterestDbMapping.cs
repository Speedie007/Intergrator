using Integrator.Models.Domain.CurriculumVitaes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Users
{
    public partial class IntegratorUserInterestDbMapping : IntegratorEntityTypeConfiguration<IntegratorUserInterest>
    {
        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<IntegratorUserInterest> builder)
        {
            builder.ToTable("IntegratorUserInterests")
                .Property(x => x.Id).HasColumnName("IntegratorUserInterestID");

            builder.HasKey(e => e.Id);

            //builder.Property(e => e.Interest)
            //       .IsRequired()
            //       .HasMaxLength(175)
            //       .IsUnicode(false);

            builder.HasOne(d => d.IntegratorUser)
                .WithMany(p => p.IntegratorUserInterests)
                .HasForeignKey(d => d.IntegratorUserID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_IntegratorUserInterests_IntegratorUsers");

            builder.HasOne(d => d.UserInterest)
                   .WithMany(p => p.IntegratorUserInterests)
                   .HasForeignKey(d => d.InterestID)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_IntegratorUserInterests_Interests");




         

            //builder.HasOne(d => d.InterestLevel)
            //    .WithMany(p => p.IntegratorUserInterests)
            //    .HasForeignKey(d => d.InterestLevelID)
            //    .OnDelete(DeleteBehavior.Restrict)
            //    .HasConstraintName("FK_IntegratorUserInterests_InterestLevels");



            base.Configure(builder);
        }
    }
}
