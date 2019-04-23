
using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.IndividualUser
{
   public partial  class UserJobSkillDbMapping : IntegratorEntityTypeConfiguration<UserJobSkill>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<UserJobSkill> builder)
        {
            builder.ToTable("UserJobSkills");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("UserJobSkillID");



            builder.HasOne(d => d.CoreKbSkill)
                      .WithMany(x => x.UserJobSkills)
                      .HasForeignKey(d => d.CoreKbSkillID)
                      .OnDelete(DeleteBehavior.Restrict)
                      .HasConstraintName("FK_UserJobSkills_CoreKBSkills");

            builder.HasOne(d => d.UserJob)
                .WithMany(p => p.UserJobSkills)
                .HasForeignKey(d => d.UserJobID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_UserJobSkills_UserJobs");


            base.Configure(builder);
        }
    }
}