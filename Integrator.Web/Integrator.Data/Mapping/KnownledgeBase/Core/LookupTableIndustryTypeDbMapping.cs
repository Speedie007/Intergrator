using Integrator.Models.Domain.KnowledgeBase.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Core
{
    public partial class LookupTableIndustryTypeDbMapping : IntegratorEntityTypeConfiguration<CoreKBIndustryType>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CoreKBIndustryType> builder)
        {
            builder.ToTable("CoreKBIndustryTypes")
              .Property(x => x.Id).HasColumnName("IndustryID");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.Industry).IsUnicode(false);

            base.Configure(builder);
        }
    }
}
