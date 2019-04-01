using Integrator.Models.Domain.KnowledgeBase.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Core
{
    public partial class LookupTableIndustryCategoryJobSkillSetDbMapping : IntegratorEntityTypeConfiguration<CoreKBIndustryCategoryJobSkillSet>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CoreKBIndustryCategoryJobSkillSet> builder)
        {
            builder.ToTable("CoreKBIndustryCategoryJobSkillSets")
              .Property(x => x.Id).HasColumnName("IndustryCategorySkillSetID");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.IndustryCategorySkillSet).IsUnicode(false);

            builder.HasOne(d => d.CoreKBIndustryCategoryJob)
                .WithMany(p => p.CoreKBIndustryCategoryJobSkillSets)
                .HasForeignKey(d => d.IndustryCategoryJobID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_IndustryCategorySkillSets_IndustryCategoryJobs");

            base.Configure(builder);
        }
    }
}
