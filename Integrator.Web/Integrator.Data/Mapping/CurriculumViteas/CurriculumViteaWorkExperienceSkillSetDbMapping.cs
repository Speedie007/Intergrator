using Integrator.Models.Domain.CurriculumVitaes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.CurriculumViteas
{
    public partial class CurriculumViteaWorkExperienceSkillSetDbMapping : IntegratorEntityTypeConfiguration<CurriculumViteaWorkExperienceSkillSets>
    {
        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CurriculumViteaWorkExperienceSkillSets> builder)
        {
            builder.ToTable("CurriculumViteaWorkExperienceSkillSets")
                .Property(x => x.Id).HasColumnName("CurriculumViteaWorkExperienceSkillSetID");

            builder.HasKey(e => e.Id);

            builder.HasOne(d => d.IntegratorUserIndustryCategoryJobSkillSet)
                .WithMany(p => p.CurriculumViteaWorkExperienceSkillSets)
                .HasForeignKey(d => d.IntegratorUserIndustryCategoryJobSkillSetID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CurriculumViteaWorkExperienceSkillSets_IntegratorUserIndustryCategoryJobSkillSets");

            builder.HasOne(d => d.CurriculumViteaWorkExperience)
                .WithMany(p => p.CurriculumViteaWorkExperienceSkillSets)
                .HasForeignKey(d => d.CurriculumViteaWorkExperienceID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CurriculumViteaWorkExperienceSkillSets_CurriculumViteaWorkExperiences");



            base.Configure(builder);
        }
    }
}
