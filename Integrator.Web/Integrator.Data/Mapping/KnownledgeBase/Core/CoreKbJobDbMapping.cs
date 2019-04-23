using Integrator.Models.Domain.KnowledgeBase.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Core
{
   public partial  class CoreKbJobDbMapping : IntegratorEntityTypeConfiguration<CoreKbJob>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CoreKbJob> builder)
        {
            builder.ToTable("CoreKbJobs");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("CoreKbJobID");


            builder.Property(e => e.CoreKbJobTitle)
                   .IsRequired()
                   .HasColumnName("CoreKBJob")
                   .HasMaxLength(150)
                   .IsUnicode(false);



            base.Configure(builder);
        }
    }
}