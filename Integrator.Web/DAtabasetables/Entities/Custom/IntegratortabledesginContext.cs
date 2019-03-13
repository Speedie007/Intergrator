using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAtabasetables.Entities.Custom
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

        //public virtual DbSet<Company> Companies { get; set; }
        //public virtual DbSet<CompanyIndustry> CompanyIndustries { get; set; }
        //public virtual DbSet<CompanyIndustryCategory> CompanyIndustryCategories { get; set; }
        //public virtual DbSet<CompanyIndustryCategoryJob> CompanyIndustryCategoryJobs { get; set; }
        //public virtual DbSet<CompanyIndustryCategoryJobSkillSet> CompanyIndustryCategoryJobSkillSets { get; set; }
        //public virtual DbSet<IntegratorUserIndustry> IntegratorUserIndustries { get; set; }
        //public virtual DbSet<IntegratorUserIndustryCategory> IntegratorUserIndustryCategories { get; set; }
        //public virtual DbSet<IntegratorUserIndustryCategoryJob> IntegratorUserIndustryCategoryJobs { get; set; }
        //public virtual DbSet<IntegratorUserIndustryCategoryJobSkillSet> IntegratorUserIndustryCategoryJobSkillSets { get; set; }
        //public virtual DbSet<LookupTableIndustryCategory> LookupTableIndustryCategories { get; set; }
        //public virtual DbSet<LookupTableIndustryCategoryJob> LookupTableIndustryCategoryJobs { get; set; }
        //public virtual DbSet<LookupTableIndustryCategoryJobSkillSet> LookupTableIndustryCategoryJobSkillSets { get; set; }
        //public virtual DbSet<LookupTableIndustryType> LookupTableIndustryTypes { get; set; }
        //public virtual DbSet<User> Users { get; set; }

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

            //modelBuilder.Entity<Company>(entity =>
            //{
            //    entity.Property(e => e.CompanyName).IsUnicode(false);
            //});

            //modelBuilder.Entity<CompanyIndustry>(entity =>
            //{
            //    entity.Property(e => e.Description).IsUnicode(false);

            //    entity.HasOne(d => d.Company)
            //        .WithMany(p => p.CompanyIndustries)
            //        .HasForeignKey(d => d.CompanyId)
            //        .HasConstraintName("FK_CompanyIndustries_Companies");

            //    entity.HasOne(d => d.Industry)
            //        .WithMany(p => p.CompanyIndustries)
            //        .HasForeignKey(d => d.IndustryId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_CompanyIndustries_Industries");
            //});

            //modelBuilder.Entity<CompanyIndustryCategory>(entity =>
            //{
            //    entity.Property(e => e.Description).IsUnicode(false);

            //    entity.HasOne(d => d.Company)
            //        .WithMany(p => p.CompanyIndustryCategories)
            //        .HasForeignKey(d => d.CompanyId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_CompanyIndustryCategories_Companies");

            //    entity.HasOne(d => d.CompanyIndustry)
            //        .WithMany(p => p.CompanyIndustryCategories)
            //        .HasForeignKey(d => d.CompanyIndustryId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_CompanyIndustryCategories_CompanyIndustries");

            //    entity.HasOne(d => d.IndustryCategory)
            //        .WithMany(p => p.CompanyIndustryCategories)
            //        .HasForeignKey(d => d.IndustryCategoryId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_CompanyIndustryCategories_IndustryCategories");
            //});

            //modelBuilder.Entity<CompanyIndustryCategoryJob>(entity =>
            //{
            //    entity.Property(e => e.Description).IsUnicode(false);

            //    entity.HasOne(d => d.Company)
            //        .WithMany(p => p.CompanyIndustryCategoryJobs)
            //        .HasForeignKey(d => d.CompanyId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_CompanyIndustryCategoryJobs_Companies");

            //    entity.HasOne(d => d.CompanyIndustryCategory)
            //        .WithMany(p => p.CompanyIndustryCategoryJobs)
            //        .HasForeignKey(d => d.CompanyIndustryCategoryId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_CompanyIndustryCategoryJobs_CompanyIndustryCategories");

            //    entity.HasOne(d => d.IndustryCategoryJob)
            //        .WithMany(p => p.CompanyIndustryCategoryJobs)
            //        .HasForeignKey(d => d.IndustryCategoryJobId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_CompanyIndustryCategoryJobs_IndustryCategoryJobs");
            //});

            //modelBuilder.Entity<CompanyIndustryCategoryJobSkillSet>(entity =>
            //{
            //    entity.Property(e => e.CompanyIndustryCategoryJobSkillSetId).ValueGeneratedNever();

            //    entity.Property(e => e.Description).IsUnicode(false);

            //    entity.HasOne(d => d.Company)
            //        .WithMany(p => p.CompanyIndustryCategoryJobSkillSets)
            //        .HasForeignKey(d => d.CompanyId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_CompanyIndustryCategoryJobSkillSets_Companies");

            //    entity.HasOne(d => d.CompanyIndustryCategoryJob)
            //        .WithMany(p => p.CompanyIndustryCategoryJobSkillSets)
            //        .HasForeignKey(d => d.CompanyIndustryCategoryJobId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_CompanyIndustryCategoryJobSkillSets_CompanyIndustryCategoryJobs");

            //    entity.HasOne(d => d.IndustryCategorySkillSet)
            //        .WithMany(p => p.CompanyIndustryCategoryJobSkillSets)
            //        .HasForeignKey(d => d.IndustryCategorySkillSetId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_CompanyIndustryCategoryJobSkillSets_IndustryCategorySkillSets");
            //});

            //modelBuilder.Entity<IntegratorUserIndustry>(entity =>
            //{
            //    entity.HasOne(d => d.Industry)
            //        .WithMany(p => p.IntegratorUserIndustries)
            //        .HasForeignKey(d => d.IndustryId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_UserIndustries_Industries");

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.IntegratorUserIndustries)
            //        .HasForeignKey(d => d.UserId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_UserIndustries_Users");
            //});

            //modelBuilder.Entity<IntegratorUserIndustryCategory>(entity =>
            //{
            //    entity.Property(e => e.Description).IsUnicode(false);

            //    entity.HasOne(d => d.IndustryCategory)
            //        .WithMany(p => p.IntegratorUserIndustryCategories)
            //        .HasForeignKey(d => d.IndustryCategoryId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_IntegratorUserIndustryCategories_IndustryCategories");

            //    entity.HasOne(d => d.IntegratorUser)
            //        .WithMany(p => p.IntegratorUserIndustryCategories)
            //        .HasForeignKey(d => d.IntegratorUserId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_IntegratorUserIndustryCategories_Users");

            //    entity.HasOne(d => d.IntegratorUserIndustry)
            //        .WithMany(p => p.IntegratorUserIndustryCategories)
            //        .HasForeignKey(d => d.IntegratorUserIndustryId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_IntegratorUserIndustryCategories_UserIndustries");
            //});

            //modelBuilder.Entity<IntegratorUserIndustryCategoryJob>(entity =>
            //{
            //    entity.Property(e => e.Description).IsUnicode(false);

            //    entity.HasOne(d => d.IndustryCategoryJob)
            //        .WithMany(p => p.IntegratorUserIndustryCategoryJobs)
            //        .HasForeignKey(d => d.IndustryCategoryJobId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_IntegratorUserIndustryCategoryJobs_IndustryCategoryJobs");

            //    entity.HasOne(d => d.IntegratorUser)
            //        .WithMany(p => p.IntegratorUserIndustryCategoryJobs)
            //        .HasForeignKey(d => d.IntegratorUserId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_IntegratorUserIndustryCategoryJobs_Users");

            //    entity.HasOne(d => d.IntegratorUserIndustryCategory)
            //        .WithMany(p => p.IntegratorUserIndustryCategoryJobs)
            //        .HasForeignKey(d => d.IntegratorUserIndustryCategoryId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_IntegratorUserIndustryCategoryJobs_IntegratorUserIndustryCategories");
            //});

            //modelBuilder.Entity<IntegratorUserIndustryCategoryJobSkillSet>(entity =>
            //{
            //    entity.Property(e => e.Description).IsUnicode(false);

            //    entity.HasOne(d => d.IndustryCategorySkillSet)
            //        .WithMany(p => p.IntegratorUserIndustryCategoryJobSkillSets)
            //        .HasForeignKey(d => d.IndustryCategorySkillSetId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_IntegratorUserIndustryCategoryJobSkillSets_IndustryCategorySkillSets");

            //    entity.HasOne(d => d.IntegratorUser)
            //        .WithMany(p => p.IntegratorUserIndustryCategoryJobSkillSets)
            //        .HasForeignKey(d => d.IntegratorUserId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_IntegratorUserIndustryCategoryJobSkillSets_Users");

            //    entity.HasOne(d => d.IntegratorUserIndustryCategoryJob)
            //        .WithMany(p => p.IntegratorUserIndustryCategoryJobSkillSets)
            //        .HasForeignKey(d => d.IntegratorUserIndustryCategoryJobId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_IntegratorUserIndustryCategoryJobSkillSets_IntegratorUserIndustryCategoryJobs");
            //});

            //modelBuilder.Entity<LookupTableIndustryCategory>(entity =>
            //{
            //    entity.HasKey(e => e.IndustryCategoryId)
            //        .HasName("PK_IndustryCategories");

            //    entity.HasOne(d => d.Industry)
            //        .WithMany(p => p.LookupTableIndustryCategories)
            //        .HasForeignKey(d => d.IndustryId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_IndustryCategories_Industries");
            //});

            //modelBuilder.Entity<LookupTableIndustryCategoryJob>(entity =>
            //{
            //    entity.HasKey(e => e.IndustryCategoryJobId)
            //        .HasName("PK_IndustryCategoryJobs");

            //    entity.Property(e => e.IndustryCategoryJobId).ValueGeneratedNever();

            //    entity.Property(e => e.JobTitle).IsUnicode(false);

            //    entity.HasOne(d => d.IndustryCategory)
            //        .WithMany(p => p.LookupTableIndustryCategoryJobs)
            //        .HasForeignKey(d => d.IndustryCategoryId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_IndustryCategoryJobs_IndustryCategories");
            //});

            //modelBuilder.Entity<LookupTableIndustryCategoryJobSkillSet>(entity =>
            //{
            //    entity.HasKey(e => e.IndustryCategorySkillSetId)
            //        .HasName("PK_IndustryCategorySkillSets");

            //    entity.Property(e => e.IndustryCategorySkillSet).IsUnicode(false);

            //    entity.HasOne(d => d.IndustryCategoryJob)
            //        .WithMany(p => p.LookupTableIndustryCategoryJobSkillSets)
            //        .HasForeignKey(d => d.IndustryCategoryJobId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_IndustryCategorySkillSets_IndustryCategoryJobs");
            //});

            //modelBuilder.Entity<LookupTableIndustryType>(entity =>
            //{
            //    entity.HasKey(e => e.IndustryId)
            //        .HasName("PK_Industries");

            //    entity.Property(e => e.Industry).IsUnicode(false);
            //});

            //modelBuilder.Entity<User>(entity =>
            //{
            //    entity.Property(e => e.UserName).IsUnicode(false);
            //});

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}