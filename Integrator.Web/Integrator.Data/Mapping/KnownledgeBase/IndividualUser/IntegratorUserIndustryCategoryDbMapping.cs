
using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.IndividualUser
{
    public partial class IntegratorUserIndustryCategoryDbMapping : IntegratorEntityTypeConfiguration<IntegratorUserIndustryCategory>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<IntegratorUserIndustryCategory> builder)
        {
            builder.ToTable("IntegratorUserIndustryCategories")
              .Property(x => x.Id).HasColumnName("IntegratorUserIndustryCategoryID");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.Description).IsUnicode(false);

            builder.HasOne(d => d.CoreKBIndustryCategory)
                .WithMany(p => p.IntegratorUserIndustryCategories)
                .HasForeignKey(d => d.CoreKBIndustryCategoryID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_IntegratorUserIndustryCategories_IndustryCategories");

            builder.HasOne(d => d.IntegratorUser)
                .WithMany(p => p.IntegratorUserIndustryCategories)
                .HasForeignKey(d => d.IntegratorUserID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_IntegratorUserIndustryCategories_Users");

            builder.HasOne(d => d.IntegratorUserIndustry)
                .WithMany(p => p.IntegratorUserIndustryCategories)
                .HasForeignKey(d => d.IntegratorUserIndustryID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_IntegratorUserIndustryCategories_UserIndustries");

            base.Configure(builder);
        }
    }
}
