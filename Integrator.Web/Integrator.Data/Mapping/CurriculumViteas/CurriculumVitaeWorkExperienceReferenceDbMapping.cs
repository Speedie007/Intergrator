using Integrator.Models.Domain.CurriculumVitaes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.CurriculumViteas
{
    public partial class CurriculumVitaeWorkExperienceReferenceDbMapping : IntegratorEntityTypeConfiguration<CurriculumVitaeWorkExperienceReferences>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CurriculumVitaeWorkExperienceReferences> builder)
        {
            builder.ToTable("CurriculumVitaeWorkExperienceReferences")
                .Property(x => x.Id).HasColumnName("CurriculumVitaeWorkExperienceReferenceID");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.ContactFirstName)
                 .IsRequired()
                 .HasMaxLength(100)
                 .IsUnicode(false);

            builder.Property(e => e.ContactLastName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
                        

          

            base.Configure(builder);
        }
    }
}