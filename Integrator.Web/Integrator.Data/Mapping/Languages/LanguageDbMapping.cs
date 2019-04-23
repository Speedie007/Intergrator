using Integrator.Models.Domain.CurriculumVitaes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Languages
{
    public partial class LanguageDbMapping : IntegratorEntityTypeConfiguration<Language>
    {
        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("Languages")
                .Property(x => x.Id).HasColumnName("LanguageID");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.LanguageSpoken)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

            builder.HasData(new Language
            {
                Id = 1,
                 LanguageSpoken = "English"
            }, new Language
            {
                Id = 2,
                LanguageSpoken = "Afrikaans"
            }, new Language
            {
                Id = 3,
                LanguageSpoken = "Xhosa"
            }, new Language
            {
                Id = 4,
                LanguageSpoken = "Zulu"
            });

            base.Configure(builder);
        }
    }
}

