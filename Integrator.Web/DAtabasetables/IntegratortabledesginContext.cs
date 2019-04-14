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

        public virtual DbSet<InegratorFileBlobs> InegratorFileBlobs { get; set; }
        public virtual DbSet<IntegratorFiles> IntegratorFiles { get; set; }
        public virtual DbSet<IntegratorUsers> IntegratorUsers { get; set; }
        public virtual DbSet<UserFiles> UserFiles { get; set; }
        public virtual DbSet<UserPictures> UserPictures { get; set; }

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

            modelBuilder.Entity<InegratorFileBlobs>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.Property(e => e.FileId)
                    .HasColumnName("FileID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FileBlob)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.File)
                    .WithOne(p => p.InegratorFileBlobs)
                    .HasForeignKey<InegratorFileBlobs>(d => d.FileId)
                    .HasConstraintName("FK_InegratorFileBlobs_IntegratorFiles");
            });

            modelBuilder.Entity<IntegratorFiles>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FileExtension)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IntegratorUsers>(entity =>
            {
                entity.HasKey(e => e.IntegratorUserId);

                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.IntegratorUserId).HasColumnName("IntegratorUserID");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<UserFiles>(entity =>
            {
                entity.HasKey(e => e.UserFileId);

                entity.HasIndex(e => e.FileId);

                entity.HasIndex(e => e.IntegratorUserId);

                entity.Property(e => e.UserFileId).HasColumnName("UserFileID");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.IntegratorUserId).HasColumnName("IntegratorUserID");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.UserFiles)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserFiles_IntegratorFiles");

                entity.HasOne(d => d.IntegratorUser)
                    .WithMany(p => p.UserFiles)
                    .HasForeignKey(d => d.IntegratorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserFiles_Users");
            });

            modelBuilder.Entity<UserPictures>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.HasIndex(e => e.IntegratorUserId);

                entity.Property(e => e.FileId)
                    .HasColumnName("FileID")
                    .ValueGeneratedNever();

                entity.Property(e => e.IntegratorUserId).HasColumnName("IntegratorUserID");

                entity.HasOne(d => d.File)
                    .WithOne(p => p.UserPictures)
                    .HasForeignKey<UserPictures>(d => d.FileId)
                    .HasConstraintName("FK_UserPictures_IntegratorFiles");

                entity.HasOne(d => d.IntegratorUser)
                    .WithMany(p => p.UserPictures)
                    .HasForeignKey(d => d.IntegratorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPicture_Users");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}