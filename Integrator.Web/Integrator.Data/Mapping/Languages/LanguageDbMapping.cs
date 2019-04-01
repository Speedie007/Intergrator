using Integrator.Models.Domain.CurriculumVitaes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Languages
{
    public partial class LanguageDbMapping : IntegratorEntityTypeConfiguration<LanguageList>
    {
        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<LanguageList> builder)
        {
            builder.ToTable("Languages")
                .Property(x => x.Id).HasColumnName("LanguageID");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Language)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

            builder.HasData(new LanguageList
            {
                Id = 1,
                 Language = "English"
            }, new LanguageList
            {
                Id = 2,
                Language = "Afrikaans"
            }, new LanguageList
            {
                Id = 3,
                Language = "Xhosa"
            }, new LanguageList
            {
                Id = 4,
                Language = "Zulu"
            });

            base.Configure(builder);
        }
    }
}

