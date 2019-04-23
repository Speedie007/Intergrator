using Integrator.Models.Domain.CurriculumVitaes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Languages
{
    public partial class IntegratorUserLanguageDbMapping : IntegratorEntityTypeConfiguration<IntegratorUserLanguages>
    {
        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<IntegratorUserLanguages> builder)
        {
            builder.ToTable("IntegratorUserLanguages")
                .Property(x => x.Id).HasColumnName("IntegratorUserLanguageID");

            builder.HasKey(e => e.Id);

            builder.HasOne(d => d.IntegratorUser)
                .WithMany(p => p.IntegratorUserLanguages)
                .HasForeignKey(d => d.IntegratorUserID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_IntegratorUserLanguages_IntegratorUsers");

            builder.HasOne(d => d.SpokenLanguage)
                .WithMany(p => p.UserLanguages)
                .HasForeignKey(d => d.LanguageID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_IntegratorUserLanguages_Languages");



            base.Configure(builder);
        }
    }
}
