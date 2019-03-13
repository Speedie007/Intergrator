using Integrator.Models.Domain.KnowledgeBase.IndividualUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.IndividualUser
{
    public partial class IntegratorUserIndustryDbMapping : IntegratorEntityTypeConfiguration<IntegratorUserIndustry>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<IntegratorUserIndustry> builder)
        {
            builder.ToTable("IntegratorUserIndustries")
              .Property(x => x.Id).HasColumnName("IntegratorUserIndustryID");

            builder.HasKey(x => x.Id);

            builder.HasOne(d => d.Industry)
                    .WithMany(p => p.IntegratorUserIndustries)
                    .HasForeignKey(d => d.IndustryID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserIndustries_Industries");

            builder.HasOne(d => d.IntegratorUser)
                .WithMany(p => p.IntegratorUserIndustries)
                .HasForeignKey(d => d.IntegratorUserID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserIndustries_Users");

            base.Configure(builder);
        }
    }
}
