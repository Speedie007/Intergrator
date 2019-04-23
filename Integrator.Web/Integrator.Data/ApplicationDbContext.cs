using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Integrator.Data.Mapping;
using Integrator.Models;
using Integrator.Models.Domain.Addresses;
using Integrator.Models.Domain.Authentication;
using Integrator.Models.Domain.Companies;
using Integrator.Models.Domain.Files;
//using Integrator.Models.Domain.KnowledgeBase.Companies;
//using Integrator.Models.Domain.KnowledgeBase.Core;
//using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Integrator.Data
{
    public class ApplicationDbContext : IdentityDbContext<
                           IntegratorUser,
                            IntegratorRole,
                            int,
                            IntegratorUserClaim,
                            IntegratorUserRole,
                            IntegratorUserLogin,
                            IntegratorRoleClaim,
                            IntegratorUserToken>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            //dynamically load all entity and query type configurations
            var typeConfigurations = Assembly.GetExecutingAssembly().GetTypes().Where(type =>
                (type.BaseType?.IsGenericType ?? false)
                    && (type.BaseType.GetGenericTypeDefinition() == typeof(IntegratorEntityTypeConfiguration<>)

                        || type.BaseType.GetGenericTypeDefinition() == typeof(IntegratorEntityTypeConfiguration<>)));

            foreach (var typeConfiguration in typeConfigurations)
            {
                var configuration = (IMappingConfiguration)Activator.CreateInstance(typeConfiguration);
                configuration.ApplyConfiguration(modelBuilder);
            }



            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<IntegratorUser>(b =>
            {
                b.ToTable("IntegratorUsers");
                b.Property(x => x.Id).HasColumnName("IntegratorUserID");

                //// Each User can have one or many Items That Are Brought onto Site
                //b.HasMany(e => e.MemberItems)
                //    .WithOne(e => e.BeachClubMember)
                //    .HasForeignKey(ul => ul.BeachClubMemberID)
                //    .IsRequired();

                //// Each User can have one or many Affiliations
                //b.HasMany(e => e.AffiliatedMembers)
                //    .WithOne(e => e.Member)
                //    .HasForeignKey(ul => ul.BeachClubMemberID)
                //    .IsRequired();

                //// Each User can have many Address
                //b.HasMany(e => e.Addresses)
                //    .WithOne(e => e.BeachClubMember)
                //    .HasForeignKey(ul => ul.BeachClubMemberID)
                //    .IsRequired();

                //// Each User can have many BoatLoackRentals
                //b.HasMany(e => e.BoatHouseRentals)
                //    .WithOne(e => e.BeachClubMember)
                //    .HasForeignKey(ul => ul.BeachClubMemberID)
                //    .IsRequired();

               

                // Each User can have many UserClaims
                b.HasMany(e => e.Claims)
                    .WithOne(e => e.IntegratorUser)
                    .HasForeignKey(uc => uc.UserId)
                    .IsRequired();

                // Each User can have many UserLogins
                b.HasMany(e => e.Logins)
                    .WithOne(e => e.IntegratorUser)
                    .HasForeignKey(ul => ul.UserId)
                    .IsRequired();

                // Each User can have many UserTokens
                b.HasMany(e => e.Tokens)
                    .WithOne(e => e.IntegratorUser)
                    .HasForeignKey(ut => ut.UserId)
                    .IsRequired();

                // Each User can have many entries in the UserRole join table
                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.IntegratorUser)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });

            modelBuilder.Entity<IntegratorUserClaim>(b =>
            {
                b.ToTable("IntegratorUserClaims");
                b.Property(x => x.Id).HasColumnName("IntegratorUserClaimID");
                b.Property(x => x.UserId).HasColumnName("IntegratorUserID");
            });

            modelBuilder.Entity<IntegratorUserLogin>(b =>
            {
                b.ToTable("IntegratorUserLogins");
                b.Property(x => x.UserId).HasColumnName("IntegratorUserID");
            });

            modelBuilder.Entity<IntegratorUserToken>(b =>
            {
                b.ToTable("IntegratorUserTokens");
                b.Property(x => x.UserId).HasColumnName("IntegratorUserID");
            });

            modelBuilder.Entity<IntegratorRole>(b =>
            {
                b.ToTable("IntegratorRoles");
                b.Property(x => x.Id).HasColumnName("IntegratorRoleID");

                // Each Role can have many entries in the UserRole join table
                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.Role)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                // Each Role can have many associated RoleClaims
                b.HasMany(e => e.RoleClaims)
                    .WithOne(e => e.Role)
                    .HasForeignKey(rc => rc.RoleId)
                    .IsRequired();
            });

            modelBuilder.Entity<IntegratorRoleClaim>(b =>
            {
                b.ToTable("IntegratorRoleClaims");
                b.Property(x => x.Id).HasColumnName("IntegratorRoleClaimID");
                b.Property(x => x.RoleId).HasColumnName("BIntegratorRoleID");
            });

            modelBuilder.Entity<IntegratorUserRole>(b =>
            {
                b.ToTable("IntegratorUserRoles");
                b.Property(x => x.UserId).HasColumnName("IntegratorUserID");
                b.Property(x => x.RoleId).HasColumnName("IntegratorRoleID");
            });

        }
    }
}
