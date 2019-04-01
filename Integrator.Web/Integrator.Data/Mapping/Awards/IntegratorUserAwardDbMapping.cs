using Integrator.Models.Domain.CurriculumVitaes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Awards
{
  public partial   class IntegratorUserAwardDbMapping : IntegratorEntityTypeConfiguration<IntegratorUserAwards>
    {
        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<IntegratorUserAwards> builder)
        {
            builder.ToTable("IntegratorUserAwards")
                .Property(x => x.Id).HasColumnName("IntegratorUserAwardID");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.AwardDescription)
                   .IsRequired()
                   .HasMaxLength(2000)
                   .IsUnicode(false);

            builder.Property(e => e.AwardTitle)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.IntegratorUserID).HasColumnName("IntegratorUserID");

            builder.HasOne(d => d.IntegratorUser)
                .WithMany(p => p.IntegratorUserAwards)
                .HasForeignKey(d => d.IntegratorUserID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_IntegratorUserAwards_IntegratorUsers");



            base.Configure(builder);
        }
    }
}
