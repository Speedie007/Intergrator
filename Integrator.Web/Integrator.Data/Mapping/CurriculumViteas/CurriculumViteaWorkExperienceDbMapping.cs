using Integrator.Models.Domain.CurriculumVitaes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.CurriculumViteas
{
    public partial class CurriculumViteaWorkExperienceDbMapping : IntegratorEntityTypeConfiguration<CurriculumViteaWorkExperiences>
    {
        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CurriculumViteaWorkExperiences> builder)
        {
            builder.ToTable("CurriculumViteaWorkExperiences")
                .Property(x => x.Id).HasColumnName("CurriculumViteaWorkExperienceID");

            builder.HasKey(e => e.Id)
                .HasName("PK_CurriculumViteaWorkExperiences");

            builder.Property(e => e.Achievments)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

            builder.Property(e => e.DateEnded)
                .HasColumnType("date")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.DateStarted)
                .HasColumnType("date")
                .HasDefaultValueSql("(getdate())");

            builder.HasOne(d => d.CurriculumVitea)
                .WithMany(p => p.CurriculumViteaWorkExperiences)
                .HasForeignKey(d => d.CurriculumViteaID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_UserWorkExperienceHistory_CurriculumViteas");

            builder.HasOne(d => d.Job)
                .WithMany(p => p.CurriculumViteaWorkExperiences)
                .HasForeignKey(d => d.IntegratorUserIndustryCategoryJobID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_UseEmploymentHistory_IntegratorUserIndustryCategoryJobs");

            builder.HasOne(d => d.Company)
                    .WithMany(p => p.CurriculumViteaWorkExperiences)
                    .HasForeignKey(d => d.CompanyID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CurriculumViteaWorkExperiences_Company");



            base.Configure(builder);
        }
    }
}
