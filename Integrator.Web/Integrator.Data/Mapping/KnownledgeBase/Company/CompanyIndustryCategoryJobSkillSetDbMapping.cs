using Integrator.Models.Domain.KnowledgeBase.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Company
{
    public partial class CompanyIndustryCategoryJobSkillSetDbMapping : IntegratorEntityTypeConfiguration<CompanyIndustryCategoryJobSkillSet>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CompanyIndustryCategoryJobSkillSet> builder)
        {
            builder.ToTable("CompanyIndustryCategoryJobSkillSets")
               .Property(x => x.Id).HasColumnName("CompanyIndustryCategoryJobSkillSetID");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.Description).IsUnicode(false);

            builder.HasOne(d => d.Company)
                .WithMany(p => p.CompanyIndustryCategoryJobSkillSets)
                .HasForeignKey(d => d.CompanyID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyIndustryCategoryJobSkillSets_Companies");

            builder.HasOne(d => d.CompanyIndustryCategoryJob)
                .WithMany(p => p.CompanyIndustryCategoryJobSkillSets)
                .HasForeignKey(d => d.CompanyIndustryCategoryJobID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyIndustryCategoryJobSkillSets_CompanyIndustryCategoryJobs");

            builder.HasOne(d => d.IndustryCategorySkillSet)
                .WithMany(p => p.CompanyIndustryCategoryJobSkillSets)
                .HasForeignKey(d => d.IndustryCategorySkillSetID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyIndustryCategoryJobSkillSets_IndustryCategorySkillSets");

            base.Configure(builder);
        }
    }
}
