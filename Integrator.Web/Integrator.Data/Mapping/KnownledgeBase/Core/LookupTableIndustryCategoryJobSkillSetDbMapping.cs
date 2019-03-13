using Integrator.Models.Domain.KnowledgeBase.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Core
{
    public partial class LookupTableIndustryCategoryJobSkillSetDbMapping : IntegratorEntityTypeConfiguration<LookupTableIndustryCategoryJobSkillSet>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<LookupTableIndustryCategoryJobSkillSet> builder)
        {
            builder.ToTable("LookupTableIndustryCategoryJobs")
              .Property(x => x.Id).HasColumnName("IndustryCategoryJobID");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.IndustryCategorySkillSet).IsUnicode(false);

            builder.HasOne(d => d.IndustryCategoryJob)
                .WithMany(p => p.LookupTableIndustryCategoryJobSkillSets)
                .HasForeignKey(d => d.IndustryCategoryJobID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IndustryCategorySkillSets_IndustryCategoryJobs");

            base.Configure(builder);
        }
    }
}
