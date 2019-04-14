using Integrator.Models.Domain.CurriculumVitaes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.CurriculumViteas
{
    public partial  class WorkExperienceReferenceContactDetailDbMapping : IntegratorEntityTypeConfiguration<WorkExperienceReferenceContactDetail>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<WorkExperienceReferenceContactDetail> builder)
        {
            builder.ToTable("WorkExperienceReferenceContactDetails")
                .Property(x => x.Id).HasColumnName("WorkExperienceReferenceContactDetailID");

            builder.HasKey(e => e.Id);

            builder.HasOne(d => d.ContactDetail)
                  .WithMany(p => p.WorkExperienceReferenceContactDetails)
                  .HasForeignKey(d => d.ContactDetailID)
                  .OnDelete(DeleteBehavior.Restrict)
                  .HasConstraintName("FK_WorkExperienceReferenceContactDetails_ContactDetails");

            builder.HasOne(d => d.CurriculumVitaeWorkExperienceReference)
                .WithMany(p => p.WorkExperienceReferenceContactDetails)
                .HasForeignKey(d => d.CurriculumVitaeWorkExperienceReferenceID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_WorkExperienceReferenceContactDetails_CurriculumVitaeWorkExperienceReferences");

            base.Configure(builder);
        }
    }
}