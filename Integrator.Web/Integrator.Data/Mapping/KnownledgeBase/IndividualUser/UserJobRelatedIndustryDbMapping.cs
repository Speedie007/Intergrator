using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.IndividualUser
{
    public partial class UserJobRelatedIndustryDbMapping : IntegratorEntityTypeConfiguration<UserJobRelatedIndustry>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<UserJobRelatedIndustry> builder)
        {
            builder.ToTable("UserJobRelatedIndustries");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("UserJobRelatedIndustryID");


            builder.HasOne(d => d.CoreKbIndustry)
                   .WithMany(p => p.UserJobRelatedIndustries)
                   .HasForeignKey(d => d.CoreKbIndustryID)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_UserJobRelatedIndustries_CoreKbIndustries");

            builder.HasOne(d => d.UserJob)
                .WithMany(p => p.UserJobRelatedIndustries)
                .HasForeignKey(d => d.UserJobID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_UserJobRelatedIndustries_UserJobs");



            base.Configure(builder);
        }
    }
}