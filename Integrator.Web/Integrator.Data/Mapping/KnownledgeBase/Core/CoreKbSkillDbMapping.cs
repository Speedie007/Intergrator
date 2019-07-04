using Integrator.Models.Domain.KnowledgeBase.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Core
{
    public partial class CoreKbSkillDbMapping : IntegratorEntityTypeConfiguration<CoreKbSkill>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CoreKbSkill> builder)
        {
            builder.ToTable("CoreKbSkills");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("CoreKbSkillID");

            builder.Property(e => e.CoreSkill)
                   .IsRequired()
                   .HasMaxLength(150)
                   .IsUnicode(false);

            builder.HasOne(d => d.CoreSkillCategory)
                .WithMany(p => p.CoreKbSkills)
                .HasForeignKey(d => d.CoreSkillCategoryID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CoreKBSkills_CoreSkillCategories");

            builder.HasData(
                    new CoreKbSkill()
                    {
                         Id=1,
                        CoreSkillCategoryID = 1,
                        CoreSkill = "Verbal Communication"
                    },
                    new CoreKbSkill()
                    {
                        Id = 2,
                        CoreSkillCategoryID = 1,
                        CoreSkill = "Body Language"
                    },
                    new CoreKbSkill()
                    {
                        Id = 3,
                        CoreSkillCategoryID = 1,
                        CoreSkill = "Physical Communication"
                    },
                    new CoreKbSkill()
                    {
                        Id = 4,
                        CoreSkillCategoryID = 1,
                        CoreSkill = "Writing "
                    },
                    new CoreKbSkill()
                    {
                        Id = 5,
                        CoreSkillCategoryID = 1,
                        CoreSkill = "Storytelling "
                    },
                    new CoreKbSkill()
                    {
                        Id = 6,
                        CoreSkillCategoryID = 1,
                        CoreSkill = "Visual Communication"
                    },
                    new CoreKbSkill()
                    {
                        Id = 7,
                        CoreSkillCategoryID = 1,
                        CoreSkill = "Humor "
                    },
                    new CoreKbSkill()
                    {
                        Id = 8,
                        CoreSkillCategoryID = 1,
                        CoreSkill = "Quick-wittedness "
                    },
                    new CoreKbSkill()
                    {
                        Id = 9,
                        CoreSkillCategoryID = 1,
                        CoreSkill = "Listening "
                    },
                    new CoreKbSkill()
                    {
                        Id = 10,
                        CoreSkillCategoryID = 1,
                        CoreSkill = "Presentation"
                    },
                    new CoreKbSkill()
                    {
                        Id = 11,
                        CoreSkillCategoryID = 1,
                        CoreSkill = "Public Speaking"
                    },
                    new CoreKbSkill()
                    {
                        Id = 12,
                        CoreSkillCategoryID = 1,
                        CoreSkill = "Interviewing "
                    },
                    new CoreKbSkill()
                    {
                        Id = 13,
                        CoreSkillCategoryID = 2,
                        CoreSkill = "Team Building "
                    },
                    new CoreKbSkill()
                    {
                        Id = 14,
                        CoreSkillCategoryID = 2,
                        CoreSkill = "Talent Management"
                    },
                    new CoreKbSkill()
                    {
                        Id = 15,
                        CoreSkillCategoryID = 2,
                        CoreSkill = "Performance Management"
                    },
                    new CoreKbSkill()
                    {
                        Id = 16,
                        CoreSkillCategoryID = 2,
                        CoreSkill = "Dispute Resolution"
                    },
                    new CoreKbSkill()
                    {
                        Id = 17,
                        CoreSkillCategoryID = 2,
                        CoreSkill = "Strategic Planning"
                    },
                    new CoreKbSkill()
                    {
                        Id = 18,
                        CoreSkillCategoryID = 2,
                        CoreSkill = "Coaching"
                    },
                    new CoreKbSkill()
                    {
                        Id = 19,
                        CoreSkillCategoryID = 2,
                        CoreSkill = "Mentoring"
                    },
                    new CoreKbSkill()
                    {
                        Id = 20,
                        CoreSkillCategoryID = 2,
                        CoreSkill = "Delegation"
                    },
                    new CoreKbSkill()
                    {
                        Id = 21,
                        CoreSkillCategoryID = 2,
                        CoreSkill = "Diplomacy"
                    },
                    new CoreKbSkill()
                    {
                        Id = 22,
                        CoreSkillCategoryID = 2,
                        CoreSkill = "Giving Feedback"
                    },
                    new CoreKbSkill()
                    {
                        Id = 23,
                        CoreSkillCategoryID = 2,
                        CoreSkill = "Managing Difficult Conversations"
                    },
                    new CoreKbSkill()
                    {
                        Id = 24,
                        CoreSkillCategoryID = 2,
                        CoreSkill = "Decision Making"
                    },
                    new CoreKbSkill()
                    {
                        Id = 25,
                        CoreSkillCategoryID = 2,
                        CoreSkill = "Supervising"
                    },
                    new CoreKbSkill()
                    {
                        Id = 26,
                        CoreSkillCategoryID = 2,
                        CoreSkill = "Managing"
                    },
                    new CoreKbSkill()
                    {
                        Id = 27,
                        CoreSkillCategoryID = 2,
                        CoreSkill = "Manager Management"
                    },
                    new CoreKbSkill()
                    {
                        Id = 28,
                        CoreSkillCategoryID = 2,
                        CoreSkill = "Managing Remote Teams"
                    },
                    new CoreKbSkill()
                    {
                        Id = 29,
                        CoreSkillCategoryID = 2,
                        CoreSkill = "Managing Virtual Teams"
                    },
                    new CoreKbSkill()
                    {
                        Id = 30,
                        CoreSkillCategoryID = 2,
                        CoreSkill = "Crisis Management"
                    },
                    new CoreKbSkill()
                    {
                        Id = 31,
                        CoreSkillCategoryID = 3,
                        CoreSkill = "Facilitation"
                    },
                    new CoreKbSkill()
                    {
                        Id = 32,
                        CoreSkillCategoryID = 3,
                        CoreSkill = "Selling"
                    },
                    new CoreKbSkill()
                    {
                        Id = 33,
                        CoreSkillCategoryID = 3,
                        CoreSkill = "Inspiring"
                    },
                    new CoreKbSkill()
                    {
                        Id = 34,
                        CoreSkillCategoryID = 3,
                        CoreSkill = "Persuasion"
                    },
                    new CoreKbSkill()
                    {
                        Id = 35,
                        CoreSkillCategoryID = 3,
                        CoreSkill = "Negotiation"
                    },
                    new CoreKbSkill()
                    {
                        Id = 36,
                        CoreSkillCategoryID = 3,
                        CoreSkill = "Motivating"
                    },
                    new CoreKbSkill()
                    {
                        Id = 37,
                        CoreSkillCategoryID = 3,
                        CoreSkill = "Collaborating"
                    },
                    //
                    new CoreKbSkill()
                    {
                        Id = 38,
                        CoreSkillCategoryID = 4,
                        CoreSkill = "Networking"
                    },
                    new CoreKbSkill()
                    {
                        Id = 39,
                        CoreSkillCategoryID = 4,
                        CoreSkill = "Interpersonal Relationships"
                    },
                    new CoreKbSkill()
                    {
                        Id = 40,
                        CoreSkillCategoryID = 4,
                        CoreSkill = "Dealing with Difficult People"
                    },
                    new CoreKbSkill()
                    {
                        Id = 41,
                        CoreSkillCategoryID = 4,
                        CoreSkill = "Conflict Resolution"
                    },
                    new CoreKbSkill()
                    {
                        Id = 42,
                        CoreSkillCategoryID = 4,
                        CoreSkill = "Personal Branding"
                    },
                    new CoreKbSkill()
                    {
                        Id = 43,
                        CoreSkillCategoryID = 4,
                        CoreSkill = "Office Politics"
                    },
                    new CoreKbSkill()
                    {
                        Id = 44,
                        CoreSkillCategoryID = 5,
                        CoreSkill = "Emotional Intelligence"
                    },
                    new CoreKbSkill()
                    {
                        Id = 45,
                        CoreSkillCategoryID = 5,
                        CoreSkill = "Office Politics"
                    },
                    new CoreKbSkill()
                    {
                        Id = 46,
                        CoreSkillCategoryID = 5,
                        CoreSkill = "Self Awareness"
                    },
                    new CoreKbSkill()
                    {
                        Id = 47,
                        CoreSkillCategoryID = 5,
                        CoreSkill = "Emotion Management"
                    },
                    new CoreKbSkill()
                    {
                        Id = 48,
                        CoreSkillCategoryID = 5,
                        CoreSkill = "Stress Management"
                    },
                    new CoreKbSkill()
                    {
                        Id = 49,
                        CoreSkillCategoryID = 5,
                        CoreSkill = "Tolerance of Change and Uncertainty"
                    },
                    new CoreKbSkill()
                    {
                        Id = 50,
                        CoreSkillCategoryID = 5,
                        CoreSkill = "Taking Criticism"
                    },
                    new CoreKbSkill()
                    {
                        Id = 51,
                        CoreSkillCategoryID = 5,
                        CoreSkill = "Self Confidence"
                    },
                    new CoreKbSkill()
                    {
                        Id = 52,
                        CoreSkillCategoryID = 5,
                        CoreSkill = "Adaptability"
                    },
                    new CoreKbSkill()
                    {
                        Id = 53,
                        CoreSkillCategoryID = 5,
                        CoreSkill = "Resilience"
                    },
                    new CoreKbSkill()
                    {
                        Id = 54,
                        CoreSkillCategoryID = 5,
                        CoreSkill = "Assertiveness"
                    },
                    new CoreKbSkill()
                    {
                        Id = 55,
                        CoreSkillCategoryID = 5,
                        CoreSkill = "Competitiveness"
                    },
                    new CoreKbSkill()
                    {
                        Id = 56,
                        CoreSkillCategoryID = 5,
                        CoreSkill = "Self Leadership"
                    },
                    new CoreKbSkill()
                    {
                        Id = 57,
                        CoreSkillCategoryID = 5,
                        CoreSkill = "Self Assessment"
                    },
                    new CoreKbSkill()
                    {
                        Id = 58,
                        CoreSkillCategoryID = 5,
                        CoreSkill = "Work-Life Balance"
                    },
                    new CoreKbSkill()
                    {
                        Id = 59,
                        CoreSkillCategoryID = 5,
                        CoreSkill = "Friendliness"
                    },
                    new CoreKbSkill()
                    {
                        Id = 60,
                        CoreSkillCategoryID = 5,
                        CoreSkill = "Enthusiasm"
                    },
                    new CoreKbSkill()
                    {
                        Id = 61,
                        CoreSkillCategoryID = 5,
                        CoreSkill = "Empathy"
                    },
                    new CoreKbSkill()
                    {
                        Id = 62,
                        CoreSkillCategoryID = 6,
                        CoreSkill = "Problem Solving"
                    },
                    new CoreKbSkill()
                    {
                        Id = 63,
                        CoreSkillCategoryID = 6,
                        CoreSkill = "Critical Thinking"
                    },
                    new CoreKbSkill()
                    {
                        Id = 64,
                        CoreSkillCategoryID = 6,
                        CoreSkill = "Innovation"
                    },
                    new CoreKbSkill()
                    {
                        Id = 65,
                        CoreSkillCategoryID = 6,
                        CoreSkill = "Troubleshooting"
                    },
                    new CoreKbSkill()
                    {
                        Id = 66,
                        CoreSkillCategoryID = 6,
                        CoreSkill = "Design Sense"
                    },
                    new CoreKbSkill()
                    {
                        Id = 67,
                        CoreSkillCategoryID = 6,
                        CoreSkill = "Artistic Sense"
                    },
                    //
                    new CoreKbSkill()
                    {
                        Id = 68,
                        CoreSkillCategoryID = 7,
                        CoreSkill = "Organization"
                    },
                    new CoreKbSkill()
                    {
                        Id = 69,
                        CoreSkillCategoryID = 7,
                        CoreSkill = "Planning"
                    },
                    new CoreKbSkill()
                    {
                        Id = 70,
                        CoreSkillCategoryID = 7,
                        CoreSkill = "Scheduling"
                    },
                    new CoreKbSkill()
                    {
                        Id = 71,
                        CoreSkillCategoryID = 7,
                        CoreSkill = "Time Management"
                    },
                    new CoreKbSkill()
                    {
                        Id = 72,
                        CoreSkillCategoryID = 7,
                        CoreSkill = "Meeting Management"
                    },
                    new CoreKbSkill()
                    {
                        Id = 73,
                        CoreSkillCategoryID = 7,
                        CoreSkill = "Technology Savvy"
                    },
                    new CoreKbSkill()
                    {
                        Id = 74,
                        CoreSkillCategoryID = 7,
                        CoreSkill = "Technology Trend Awareness"
                    },
                    new CoreKbSkill()
                    {
                        Id = 75,
                        CoreSkillCategoryID = 7,
                        CoreSkill = "Business Trend Awareness"
                    },
                    new CoreKbSkill()
                    {
                        Id = 76,
                        CoreSkillCategoryID = 7,
                        CoreSkill = "Research"
                    },
                    new CoreKbSkill()
                    {
                        Id = 77,
                        CoreSkillCategoryID = 7,
                        CoreSkill = "Business Etiquette"
                    },
                    new CoreKbSkill()
                    {
                        Id = 78,
                        CoreSkillCategoryID = 7,
                        CoreSkill = "Business Ethics"
                    },
                    new CoreKbSkill()
                    {
                        Id = 79,
                        CoreSkillCategoryID = 7,
                        CoreSkill = "Diversity Awareness"
                    },
                    new CoreKbSkill()
                    {
                        Id = 80,
                        CoreSkillCategoryID = 7,
                        CoreSkill = "Disability Awareness"
                    },
                    new CoreKbSkill()
                    {
                        Id = 81,
                        CoreSkillCategoryID = 7,
                        CoreSkill = "Intercultural Competence"
                    },
                    new CoreKbSkill()
                    {
                        Id = 82,
                        CoreSkillCategoryID = 7,
                        CoreSkill = "Training"
                    },
                    new CoreKbSkill()
                    {
                        Id = 83,
                        CoreSkillCategoryID = 7,
                        CoreSkill = "Train the Trainer"
                    },
                    new CoreKbSkill()
                    {
                        Id = 84,
                        CoreSkillCategoryID = 7,
                        CoreSkill = "Process Improvement"
                    },
                    new CoreKbSkill()
                    {
                        Id = 85,
                        CoreSkillCategoryID = 7,
                        CoreSkill = "Knowledge Management"
                    },
                    new CoreKbSkill()
                    {
                        Id = 86,
                        CoreSkillCategoryID = 7,
                        CoreSkill = "Writing Reports and Proposals"
                    },
                    new CoreKbSkill()
                    {
                        Id = 87,
                        CoreSkillCategoryID = 7,
                        CoreSkill = "Customer Service"
                    },
                    new CoreKbSkill()
                    {
                        Id = 88,
                        CoreSkillCategoryID = 7,
                        CoreSkill = "Entrepreneurial Thinking"
                    });


            base.Configure(builder);
        }
    }
}