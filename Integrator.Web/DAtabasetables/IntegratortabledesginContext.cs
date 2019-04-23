using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAtabasetables
{
    public partial class IntegratortabledesginContext : DbContext
    {
        public IntegratortabledesginContext()
        {
        }

        public IntegratortabledesginContext(DbContextOptions<IntegratortabledesginContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CoreKbskillTypes> CoreKbskillTypes { get; set; }
        public virtual DbSet<CoreKbskills> CoreKbskills { get; set; }
        public virtual DbSet<CoreSkillCategories> CoreSkillCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=IntegratorTableDesgin;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<CoreKbskillTypes>(entity =>
            {
                entity.HasKey(e => e.CoreKbskillTypeId);

                entity.ToTable("CoreKBSkillTypes");

                entity.Property(e => e.CoreKbskillTypeId).HasColumnName("CoreKBSkillTypeID");

                entity.Property(e => e.CoreKbskillType)
                    .IsRequired()
                    .HasColumnName("CoreKBSkillType")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoreKbskills>(entity =>
            {
                entity.HasKey(e => e.CoreKbskillId)
                    .HasName("PK_CoreSoftSkills");

                entity.ToTable("CoreKBSkills");

                entity.Property(e => e.CoreKbskillId).HasColumnName("CoreKBSkillID");

                entity.Property(e => e.CoreSkill)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoreSkillCategoryId).HasColumnName("CoreSkillCategoryID");

                entity.HasOne(d => d.CoreSkillCategory)
                    .WithMany(p => p.CoreKbskills)
                    .HasForeignKey(d => d.CoreSkillCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CoreKBSkills_CoreSkillCategories");
            });

            modelBuilder.Entity<CoreSkillCategories>(entity =>
            {
                entity.HasKey(e => e.CoreSkillCategoryId)
                    .HasName("PK_CoreSoftSkillCategories");

                entity.Property(e => e.CoreSkillCategoryId).HasColumnName("CoreSkillCategoryID");

                entity.Property(e => e.CoreKbskillTypeId).HasColumnName("CoreKBSkillTypeID");

                entity.Property(e => e.CoreSkillCategory)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CoreKbskillType)
                    .WithMany(p => p.CoreSkillCategories)
                    .HasForeignKey(d => d.CoreKbskillTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CoreSkillCategories_CoreKBSkillTypes");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}