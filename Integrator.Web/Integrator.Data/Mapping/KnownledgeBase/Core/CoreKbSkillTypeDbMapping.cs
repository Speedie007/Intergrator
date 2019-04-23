using Integrator.Models.Domain.EnumClasses;
using Integrator.Models.Domain.KnowledgeBase.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Core
{
    public partial class CoreKbSkillTypeDbMapping : IntegratorEntityTypeConfiguration<CoreKbSkillType>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CoreKbSkillType> builder)
        {
            builder.ToTable("CoreKbSkillTypes");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("CoreKbSkillTypeID");



            builder.Property(e => e.CoreKbSkillTypeName)
                  .IsRequired()
                  .HasColumnName("CoreKBSkillType")
                  .HasMaxLength(100)
                  .IsUnicode(false);

            Array enumValueArray = Enum.GetValues(typeof(EnumKbSkillType));
            List<CoreKbSkillType> ListOfSkillTypes = new List<CoreKbSkillType>();
            foreach (int enumValue in enumValueArray)
            {
                ListOfSkillTypes.Add(new CoreKbSkillType()
                {
                    Id = enumValue,
                    CoreKbSkillTypeName = Enum.GetName(typeof(EnumKbSkillType), enumValue)
                });
            }
            builder.HasData(ListOfSkillTypes);

            base.Configure(builder);
        }
    }
}