using Integrator.Models.Domain.CurriculumVitaes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Qualifications
{
    public partial class QualificationLevelDbMapping : IntegratorEntityTypeConfiguration<QualificationLevels>
    {
        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<QualificationLevels> builder)
        {
            builder.ToTable("QualificationLevels")
                .Property(x => x.Id).HasColumnName("QualificationLevelID");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.QualificationLevel)
                .HasMaxLength(100)
                .IsUnicode(false);
            builder.HasData(new QualificationLevels
            {
                Id = 1,
                QualificationLevel = "Masters Degree"
            });

            builder.HasData(new QualificationLevels
            {
                Id = 2,
                QualificationLevel = "Honours Degree"
            });
            builder.HasData(new QualificationLevels
            {
                Id = 3,
                QualificationLevel = "Degree"
            });
            builder.HasData(new QualificationLevels
            {
                Id = 4,
                QualificationLevel = "Doctorial Degree"
            });
            builder.HasData(new QualificationLevels
            {
                Id = 5,
                QualificationLevel = "Certificate"
            });

            builder.HasData(new QualificationLevels
            {
                Id = 6,
                QualificationLevel = "Shool Level Equivalent"
            });




            base.Configure(builder);
        }
    }
}
