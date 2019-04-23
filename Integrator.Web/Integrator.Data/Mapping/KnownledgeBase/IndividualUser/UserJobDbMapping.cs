using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.IndividualUser
{
   public partial  class UserJobDbMapping : IntegratorEntityTypeConfiguration<UserJob>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<UserJob> builder)
        {
            builder.ToTable("UserJobs");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("UserJobID");



            builder.Property(e => e.Achievments)
                     .IsUnicode(false)
                     .HasDefaultValueSql("('')");



            builder.Property(e => e.DateEnded)
                .HasColumnType("date")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.DateStarted)
                .HasColumnType("date")
                .HasDefaultValueSql("(getdate())");



            builder.Property(e => e.WorkExperienceDescription)
                .IsRequired()
                .IsUnicode(false);

            builder.HasOne(d => d.CoreKbJob)
                .WithMany(p => p.UserJobs)
                .HasForeignKey(d => d.CoreKbJobID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_UserJobs_CoreKBJobs");

            builder.HasOne(d => d.CurriculumVitea)
                .WithMany(p => p.UserJobs)
                .HasForeignKey(d => d.CurriculumViteaID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_UserJobs_CurriculumViteas");

            builder.HasOne(d => d.IntegratorUser)
                  .WithMany(p => p.UserJobs)
                  .HasForeignKey(d => d.IntegratorUserID)
                  .OnDelete(DeleteBehavior.Restrict)
                  .HasConstraintName("FK_UserJobs_IntegratorUsers");

            builder.HasOne(d => d.Company)
                  .WithMany(p => p.UserJobs)
                  .HasForeignKey(d => d.CompanyID)
                  .OnDelete(DeleteBehavior.Restrict)
                  .HasConstraintName("FK_UserJobs_Company");


            base.Configure(builder);
        }
    }
}