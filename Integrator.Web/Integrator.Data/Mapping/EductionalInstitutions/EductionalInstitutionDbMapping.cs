using Integrator.Models.Domain.CurriculumVitaes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.EductionalInstitutions
{
    class EductionalInstitutionDbMapping : IntegratorEntityTypeConfiguration<EductaionalInstitutions>
    {
        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<EductaionalInstitutions> builder)
        {
            builder.ToTable("EductaionalInstitutions")
                .Property(x => x.Id).HasColumnName("EductaionalInstitutionID");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.EductaionalInstitution)
                     .HasMaxLength(150)
                     .IsUnicode(false);



            base.Configure(builder);
        }
    }
}
