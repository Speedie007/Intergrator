using Integrator.Models.Domain.CurriculumVitaes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Qualifications
{
    public partial class UserQualificationDbMapping : IntegratorEntityTypeConfiguration<UserQualifications>
    {
        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<UserQualifications> builder)
        {
            builder.ToTable("UserQualifications")
                .Property(x => x.Id).HasColumnName("UserQualificationID");

            builder.HasKey(e => e.Id);

           
            builder.Property(e => e.QualificationTitle)
                .IsRequired()
                .HasMaxLength(175)
                .IsUnicode(false);

            builder.Property(e => e.YearCompletedQualification)
                .HasColumnType("date")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.YearStartedQualification)
                .HasColumnType("date")
                .HasDefaultValueSql("(getdate())");

            builder.HasOne(d => d.EductaionalInstitution)
                .WithMany(p => p.UserQualifications)
                .HasForeignKey(d => d.EductaionalInstitutionID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_UserQualifications_EductaionalInstitutions");

            builder.HasOne(d => d.IntegratorUser)
                .WithMany(p => p.UserQualifications)
                .HasForeignKey(d => d.IntegratorUserID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_UserQualifications_IntegratorUsers");

            builder.HasOne(d => d.QualificationLevel)
                .WithMany(p => p.UserQualifications)
                .HasForeignKey(d => d.QualificationLevelID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_UserQualifications_QualificationLevels");



            base.Configure(builder);
        }
    }
}
