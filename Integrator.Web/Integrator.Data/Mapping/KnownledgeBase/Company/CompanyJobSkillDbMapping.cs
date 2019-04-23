
using Integrator.Models.Domain.KnowledgeBase.Companies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Company
{
    public partial class CompanyJobSkillDbMapping : IntegratorEntityTypeConfiguration<CompanyJobSkill>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CompanyJobSkill> builder)
        {
            builder.ToTable("CompanyJobSkills");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("CompanyJobSkillID");

            builder.HasOne(d => d.CompanyJob)
                   .WithMany(p => p.CompanyJobSkills)
                   .HasForeignKey(d => d.CompanyJobID)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_CompanyJobSkills_CompanyJobs");

            builder.HasOne(d => d.CoreKbSkill)
                .WithMany(p => p.CompanyJobSkills)
                .HasForeignKey(d => d.CoreKbSkillID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyJobSkills_CoreKBSkills");


            base.Configure(builder);
        }
    }
}