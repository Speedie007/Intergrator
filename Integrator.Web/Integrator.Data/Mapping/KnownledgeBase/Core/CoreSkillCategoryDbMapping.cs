using Integrator.Models.Domain.KnowledgeBase.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Core
{
    public partial class CoreSkillCategoryDbMapping : IntegratorEntityTypeConfiguration<CoreSkillCategory>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CoreSkillCategory> builder)
        {
            builder.ToTable("CoreSkillCategories");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("CoreSkillCategoryID");



            builder.Property(e => e.CoreSkillCategoryName)
                     .IsRequired()
                     .HasMaxLength(100)
                     .IsUnicode(false);

            builder.HasOne(d => d.CoreKbSkillType)
                    .WithMany(p => p.CoreSkillCategories)
                    .HasForeignKey(d => d.CoreKbSkillTypeID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CoreSkillCategories_CoreKBSkillTypes");

            builder.HasData(new CoreSkillCategory()
            {
                Id = 1,
                CoreKbSkillTypeID = 2,
                CoreSkillCategoryName = "Communication"
            },
            new CoreSkillCategory()
            {
                Id = 2,
                CoreKbSkillTypeID = 2,
                CoreSkillCategoryName = "Leadership"
            },
            new CoreSkillCategory()
            {
                Id = 3,
                CoreKbSkillTypeID = 2,
                CoreSkillCategoryName = "Influencing"
            },
            new CoreSkillCategory()
            {
                Id = 4,
                CoreKbSkillTypeID = 2,
                CoreSkillCategoryName = "Creativity"
            }, new CoreSkillCategory()
            {
                Id = 5,
                CoreKbSkillTypeID = 2,
                CoreSkillCategoryName = "Professional"
            },
            new CoreSkillCategory()
            {
                Id = 6,
                CoreKbSkillTypeID = 2,
                CoreSkillCategoryName = "Interpersonal"
            },
            new CoreSkillCategory()
            {
                Id = 7,
                CoreKbSkillTypeID = 2,
                CoreSkillCategoryName = "Personal"
            });

            base.Configure(builder);
        }
    }
}