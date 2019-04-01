using Integrator.Models.Domain.CurriculumVitaes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.CurriculumViteas
{
    public partial class CurriculumViteaDbMapping : IntegratorEntityTypeConfiguration<CurriculumVitea>
    {
        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CurriculumVitea> builder)
        {
            builder.ToTable("CurriculumViteas")
                .Property(x => x.Id).HasColumnName("CurriculumViteaID");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.CareerSummary)
                    .IsRequired()
                    .IsUnicode(false);

            builder.Property(e => e.DateLastUpdated).HasColumnType("datetime");


            builder.HasOne(d => d.IntegratorUser)
                .WithMany(p => p.CurriculumViteas)
                .HasForeignKey(d => d.IntegratorUserID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CurriculumViteas_IntegratorUsers");


            base.Configure(builder);
        }
    }
}
