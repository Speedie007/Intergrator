using Integrator.Models.Domain.KnowledgeBase.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Core
{
    public partial class CoreKbIndustryDbMapping : IntegratorEntityTypeConfiguration<CoreKbIndustry>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CoreKbIndustry> builder)
        {
            builder.ToTable("CoreKbIndustries");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("CoreKbIndustryID");


            builder.Property(e => e.CoreKbIndustryName)
                               .IsRequired()
                               .HasColumnName("CoreKBIndustryName")
                               .HasMaxLength(150)
                               .IsUnicode(false);

            builder.HasOne(d => d.CoreKbIndustryCategory)
                .WithMany(p => p.CoreKbIndustries)
                .HasForeignKey(d => d.CoreKbIndustryCategoryID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CoreKbIndustrySectors_CoreKBIdustryCategories");

            builder.HasData(new CoreKbIndustry()
            {
                Id = 1,
                CoreKbIndustryCategoryID = 1,
                CoreKbIndustryName = "Crop Production"
            },
            new CoreKbIndustry()
            {
                Id = 2,
                CoreKbIndustryCategoryID = 1,
                CoreKbIndustryName = "Animal Production and Aquaculture"
            },
            new CoreKbIndustry()
            {
                Id = 3,
                CoreKbIndustryCategoryID = 1,
                CoreKbIndustryName = "Forestry and Logging"
            },
            new CoreKbIndustry()
            {
                Id = 4,
                CoreKbIndustryCategoryID = 1,
                CoreKbIndustryName = "Fishing, Hunting and Trapping"
            },
             new CoreKbIndustry()
             {
                 Id = 5,
                 CoreKbIndustryCategoryID = 1,
                 CoreKbIndustryName = "Support Activities for Agriculture and Forestry"
             },
             new CoreKbIndustry()
             {
                 Id = 6,
                 CoreKbIndustryCategoryID = 2,
                 CoreKbIndustryName = "Oil and Gas Extraction"
             },
             new CoreKbIndustry()
             {
                 Id = 7,
                 CoreKbIndustryCategoryID = 2,
                 CoreKbIndustryName = "Mining (except Oil and Gas)"
             },
             new CoreKbIndustry()
             {
                 Id = 8,
                 CoreKbIndustryCategoryID = 2,
                 CoreKbIndustryName = "Support Activities for Mining"
             },
             //
             new CoreKbIndustry()
             {
                 Id = 9,
                 CoreKbIndustryCategoryID = 3,
                 CoreKbIndustryName = "Electric Power Generation, Transmission and Distribution"
             },
             new CoreKbIndustry()
             {
                 Id = 10,
                 CoreKbIndustryCategoryID = 3,
                 CoreKbIndustryName = "Natural Gas Distribution"
             },
             new CoreKbIndustry()
             {
                 Id = 11,
                 CoreKbIndustryCategoryID = 3,
                 CoreKbIndustryName = "Water, Sewage and Other Systems"
             },
             //
             new CoreKbIndustry()
             {
                 Id = 12,
                 CoreKbIndustryCategoryID = 4,
                 CoreKbIndustryName = "Construction of Buildings"
             },
             new CoreKbIndustry()
             {
                 Id = 13,
                 CoreKbIndustryCategoryID = 4,
                 CoreKbIndustryName = "Heavy and Civil Engineering Construction"
             },
             new CoreKbIndustry()
             {
                 Id = 14,
                 CoreKbIndustryCategoryID = 4,
                 CoreKbIndustryName = "Specialty Trade Contractors"
             },
             //Man
             new CoreKbIndustry()
             {
                 Id = 15,
                 CoreKbIndustryCategoryID = 5,
                 CoreKbIndustryName = "Food Manufacturing"
             },
             new CoreKbIndustry()
             {
                 Id = 16,
                 CoreKbIndustryCategoryID = 5,
                 CoreKbIndustryName = "Beverage and Tobacco Product Manufacturing"
             },
             new CoreKbIndustry()
             {
                 Id = 17,
                 CoreKbIndustryCategoryID = 5,
                 CoreKbIndustryName = "Textile Mills"
             },
             new CoreKbIndustry()
             {
                 Id = 18,
                 CoreKbIndustryCategoryID = 5,
                 CoreKbIndustryName = "Apparel Manufacturing"
             },
             new CoreKbIndustry()
             {
                 Id = 19,
                 CoreKbIndustryCategoryID = 5,
                 CoreKbIndustryName = "Leather and Allied Product Manufacturing"
             },
             new CoreKbIndustry()
             {
                 Id = 20,
                 CoreKbIndustryCategoryID = 5,
                 CoreKbIndustryName = "Wood Product Manufacturing"
             },
             new CoreKbIndustry()
             {
                 Id = 21,
                 CoreKbIndustryCategoryID = 5,
                 CoreKbIndustryName = "Paper Manufacturing"
             },
             new CoreKbIndustry()
             {
                 Id = 22,
                 CoreKbIndustryCategoryID = 5,
                 CoreKbIndustryName = "Printing and Related Support Activities"
             },
             new CoreKbIndustry()
             {
                 Id = 23,
                 CoreKbIndustryCategoryID = 5,
                 CoreKbIndustryName = "Petroleum and Coal Products Manufacturing"
             },
             new CoreKbIndustry()
             {
                 Id = 24,
                 CoreKbIndustryCategoryID = 5,
                 CoreKbIndustryName = "Chemical Manufacturing"
             },
             new CoreKbIndustry()
             {
                 Id = 25,
                 CoreKbIndustryCategoryID = 5,
                 CoreKbIndustryName = "Plastics and Rubber Products Manufacturing"
             },
             new CoreKbIndustry()
             {
                 Id = 26,
                 CoreKbIndustryCategoryID = 5,
                 CoreKbIndustryName = "Nonmetallic Mineral Product Manufacturing"
             },
             new CoreKbIndustry()
             {
                 Id = 27,
                 CoreKbIndustryCategoryID = 5,
                 CoreKbIndustryName = "Primary Metal Manufacturing"
             },
             new CoreKbIndustry()
             {
                 Id = 28,
                 CoreKbIndustryCategoryID = 5,
                 CoreKbIndustryName = "Fabricated Metal Product Manufacturing"
             },
             new CoreKbIndustry()
             {
                 Id = 29,
                 CoreKbIndustryCategoryID = 5,
                 CoreKbIndustryName = "Machinery Manufacturing"
             },
             new CoreKbIndustry()
             {
                 Id = 30,
                 CoreKbIndustryCategoryID = 5,
                 CoreKbIndustryName = "Computer and Electronic Product Manufacturing"
             },
             new CoreKbIndustry()
             {
                 Id = 31,
                 CoreKbIndustryCategoryID = 5,
                 CoreKbIndustryName = "Electrical Equipment, Appliance, and Component Manufacturing"
             },
             new CoreKbIndustry()
             {
                 Id = 32,
                 CoreKbIndustryCategoryID = 5,
                 CoreKbIndustryName = "Transportation Equipment Manufacturing"
             },
             new CoreKbIndustry()
             {
                 Id = 33,
                 CoreKbIndustryCategoryID = 5,
                 CoreKbIndustryName = "Furniture and Related Product Manufacturing"
             },
             new CoreKbIndustry()
             {
                 Id = 34,
                 CoreKbIndustryCategoryID = 5,
                 CoreKbIndustryName = "Miscellaneous Manufacturing"
             },
             //----------------------------
             new CoreKbIndustry()
             {
                 Id = 35,
                 CoreKbIndustryCategoryID = 6,
                 CoreKbIndustryName = "Merchant Wholesalers, Durable Goods"
             },
             new CoreKbIndustry()
             {
                 Id = 36,
                 CoreKbIndustryCategoryID = 6,
                 CoreKbIndustryName = "Merchant Wholesalers, Non-Durable Goods"
             },
             new CoreKbIndustry()
             {
                 Id = 37,
                 CoreKbIndustryCategoryID = 6,
                 CoreKbIndustryName = "Wholesale Electronic Markets and Agents and Brokers"
             },
             //---------------------------------
             new CoreKbIndustry()
             {
                 Id = 38,
                 CoreKbIndustryCategoryID = 7,
                 CoreKbIndustryName = "Motor Vehicle and Parts Dealers"
             },
             new CoreKbIndustry()
             {
                 Id = 39,
                 CoreKbIndustryCategoryID = 7,
                 CoreKbIndustryName = "Furniture and Home Furnishings Stores"
             },
             new CoreKbIndustry()
             {
                 Id = 40,
                 CoreKbIndustryCategoryID = 7,
                 CoreKbIndustryName = "Electronics and Appliance Stores"
             },
             new CoreKbIndustry()
             {
                 Id = 41,
                 CoreKbIndustryCategoryID = 7,
                 CoreKbIndustryName = "Building Material, Garden Equipment and Supplies Dealers"
             },
             new CoreKbIndustry()
             {
                 Id = 42,
                 CoreKbIndustryCategoryID = 7,
                 CoreKbIndustryName = "Food and Beverage Stores"
             },
             new CoreKbIndustry()
             {
                 Id = 43,
                 CoreKbIndustryCategoryID = 7,
                 CoreKbIndustryName = "Health and Personal Care Stores"
             },
             new CoreKbIndustry()
             {
                 Id = 44,
                 CoreKbIndustryCategoryID = 7,
                 CoreKbIndustryName = "Gasoline Stations"
             },
             new CoreKbIndustry()
             {
                 Id = 45,
                 CoreKbIndustryCategoryID = 7,
                 CoreKbIndustryName = "Clothing and Clothing Accessories Stores"
             },
             new CoreKbIndustry()
             {
                 Id = 46,
                 CoreKbIndustryCategoryID = 7,
                 CoreKbIndustryName = "Sporting Goods, Hobby, Musical Instrument, and Book Stores"
             },
             new CoreKbIndustry()
             {
                 Id = 47,
                 CoreKbIndustryCategoryID = 7,
                 CoreKbIndustryName = "General Merchandise Stores"
             },
             new CoreKbIndustry()
             {
                 Id = 48,
                 CoreKbIndustryCategoryID = 7,
                 CoreKbIndustryName = "Miscellaneous Store Retailers"
             },
             new CoreKbIndustry()
             {
                 Id = 49,
                 CoreKbIndustryCategoryID = 7,
                 CoreKbIndustryName = "Nonstore Retailers"
             },
             //--------------------
             new CoreKbIndustry()
             {
                 Id = 50,
                CoreKbIndustryCategoryID = 8,
                 CoreKbIndustryName = "Air Transportation"
             },
             new CoreKbIndustry()
             {
                 Id = 51,
                CoreKbIndustryCategoryID = 8,
                 CoreKbIndustryName = "Rail Transportation"
             },
             new CoreKbIndustry()
             {
                 Id = 52,
                CoreKbIndustryCategoryID = 8,
                 CoreKbIndustryName = "Water Transportation"
             },
             new CoreKbIndustry()
             {
                 Id = 53,
                CoreKbIndustryCategoryID = 8,
                 CoreKbIndustryName = "Truck Transportation"
             },
             new CoreKbIndustry()
             {
                 Id = 54,
                CoreKbIndustryCategoryID = 8,
                 CoreKbIndustryName = "Pipeline Transportation"
             },
             new CoreKbIndustry()
             {
                 Id = 55,
                CoreKbIndustryCategoryID = 8,
                 CoreKbIndustryName = "Scenic and Sightseeing Transportation"
             },
             new CoreKbIndustry()
             {
                 Id = 56,
                CoreKbIndustryCategoryID = 8,
                 CoreKbIndustryName = "Support Activities for Transportation"
             },
             new CoreKbIndustry()
             {
                 Id = 57,
                CoreKbIndustryCategoryID = 8,
                 CoreKbIndustryName = "Postal Service"
             },
             new CoreKbIndustry()
             {
                 Id = 58,
                CoreKbIndustryCategoryID = 8,
                 CoreKbIndustryName = "Couriers and Messengers"
             },
             new CoreKbIndustry()
             {
                 Id = 59,
                CoreKbIndustryCategoryID = 8,
                 CoreKbIndustryName = "Warehousing and Storage"
             },
             //-------------------
             new CoreKbIndustry()
             {
                 Id = 60,
                CoreKbIndustryCategoryID = 9,
                 CoreKbIndustryName = "Publishing Industries (Except Internet)"
             },
             new CoreKbIndustry()
             {
                 Id = 61,
                CoreKbIndustryCategoryID = 9,
                 CoreKbIndustryName = "Motion Picture and Sound Recording Industries"
             },
             new CoreKbIndustry()
             {
                 Id = 62,
                CoreKbIndustryCategoryID = 9,
                 CoreKbIndustryName = "Broadcasting (except Internet)"
             },
             new CoreKbIndustry()
             {
                 Id = 63,
                CoreKbIndustryCategoryID = 9,
                 CoreKbIndustryName = "Data Processing, Hosting, and Related Services"
             },
             new CoreKbIndustry()
             {
                 Id = 64,
                CoreKbIndustryCategoryID = 9,
                 CoreKbIndustryName = "Other Information Services"
             },
             new CoreKbIndustry()
             {
                 Id = 65,
                CoreKbIndustryCategoryID = 9,
                 CoreKbIndustryName = "Telecommunications"
             },
             //-----------------------
             new CoreKbIndustry()
             {
                 Id = 66,
                 CoreKbIndustryCategoryID = 10,
                 CoreKbIndustryName = "Monetary Authorities-Central Bank"
             },
             new CoreKbIndustry()
             {
                 Id = 67,
                 CoreKbIndustryCategoryID = 10,
                 CoreKbIndustryName = "Credit Intermediation and Related Activities"
             },
             new CoreKbIndustry()
             {
                 Id = 68,
                 CoreKbIndustryCategoryID = 10,
                 CoreKbIndustryName = "Securities, Commodity Contracts, and Other Financial Investments"
             },
             new CoreKbIndustry()
             {
                 Id = 69,
                 CoreKbIndustryCategoryID = 10,
                 CoreKbIndustryName = "Insurance Carriers and Related Activities"
             },
             new CoreKbIndustry()
             {
                 Id = 70,
                 CoreKbIndustryCategoryID = 10,
                 CoreKbIndustryName = "Funds, Trusts, and Other Financial Vehicles"
             },
             //---------------------
             new CoreKbIndustry()
             {
                 Id = 71,
                 CoreKbIndustryCategoryID = 11,
                 CoreKbIndustryName = "Real Estate"
             },
             new CoreKbIndustry()
             {
                 Id = 72,
                 CoreKbIndustryCategoryID = 11,
                 CoreKbIndustryName = "Rental and Leasing Services"
             },
             new CoreKbIndustry()
             {
                 Id = 73,
                 CoreKbIndustryCategoryID = 11,
                 CoreKbIndustryName = "Lessors of Nonfinancial Intangible Assets"
             },
             //-------------------------------
             new CoreKbIndustry()
             {
                 Id = 74,
                 CoreKbIndustryCategoryID = 12,
                 CoreKbIndustryName = "Legal Services"
             },
             new CoreKbIndustry()
             {
                 Id = 75,
                 CoreKbIndustryCategoryID = 12,
                 CoreKbIndustryName = "Accounting, Tax Preparation, Bookkeeping, and Payroll Services"
             },
             new CoreKbIndustry()
             {
                 Id = 76,
                 CoreKbIndustryCategoryID = 12,
                 CoreKbIndustryName = "Lessors of Nonfinancial Intangible Assets"
             },
             new CoreKbIndustry()
             {
                 Id = 77,
                 CoreKbIndustryCategoryID = 12,
                 CoreKbIndustryName = "Architectural, Engineering, and Related Services"
             },
             new CoreKbIndustry()
             {
                 Id = 78,
                 CoreKbIndustryCategoryID = 12,
                 CoreKbIndustryName = "Specialized Design Services"
             },
             new CoreKbIndustry()
             {
                 Id = 79,
                 CoreKbIndustryCategoryID = 12,
                 CoreKbIndustryName = "Management, Scientific, and Technical Consulting Services"
             },
             new CoreKbIndustry()
             {
                 Id = 80,
                 CoreKbIndustryCategoryID = 12,
                 CoreKbIndustryName = "Scientific Research and Development Services"
             },
             new CoreKbIndustry()
             {
                 Id = 81,
                 CoreKbIndustryCategoryID = 12,
                 CoreKbIndustryName = "Advertising, Public Relations, and Related Services"
             },
             new CoreKbIndustry()
             {
                 Id = 82,
                 CoreKbIndustryCategoryID = 12,
                 CoreKbIndustryName = "Other Professional, Scientific, and Technical Services"
             },
             //----
             new CoreKbIndustry()
             {
                 Id = 83,
                 CoreKbIndustryCategoryID = 13,
                 CoreKbIndustryName = "Management of Companies and Enterprises"
             },
             //******
             new CoreKbIndustry()
             {
                 Id = 84,
                 CoreKbIndustryCategoryID = 14,
                 CoreKbIndustryName = "Administrative and Support Services"
             },
             new CoreKbIndustry()
             {
                 Id = 85,
                 CoreKbIndustryCategoryID = 14,
                 CoreKbIndustryName = "Waste Management and Remediation Services"
             },
             //*******
             new CoreKbIndustry()
             {
                 Id = 86,
                 CoreKbIndustryCategoryID = 15,
                 CoreKbIndustryName = "Elementary and Secondary Schools"
             },
             new CoreKbIndustry()
             {
                 Id = 87,
                 CoreKbIndustryCategoryID = 15,
                 CoreKbIndustryName = "Junior Colleges"
             },
             new CoreKbIndustry()
             {
                 Id = 88,
                 CoreKbIndustryCategoryID = 15,
                 CoreKbIndustryName = "Colleges, Universities, and Professional Schools"
             },
             new CoreKbIndustry()
             {
                 Id = 89,
                 CoreKbIndustryCategoryID = 15,
                 CoreKbIndustryName = "Business Schools and Computer and Management Training"
             },
             new CoreKbIndustry()
             {
                 Id = 90,
                 CoreKbIndustryCategoryID = 15,
                 CoreKbIndustryName = "Technical and Trade Schools"
             },
             new CoreKbIndustry()
             {
                 Id = 91,
                 CoreKbIndustryCategoryID = 15,
                 CoreKbIndustryName = "Other Schools and Instruction"
             },
             new CoreKbIndustry()
             {
                 Id = 92,
                 CoreKbIndustryCategoryID = 15,
                 CoreKbIndustryName = "Educational Support Services"
             },
             //*******
             new CoreKbIndustry()
             {
                 Id = 93,
                 CoreKbIndustryCategoryID = 16,
                 CoreKbIndustryName = "Ambulatory Health Care Services"
             },
             new CoreKbIndustry()
             {
                 Id = 94,
                 CoreKbIndustryCategoryID = 16,
                 CoreKbIndustryName = "Hospitals"
             },
             new CoreKbIndustry()
             {
                 Id = 95,
                 CoreKbIndustryCategoryID = 16,
                 CoreKbIndustryName = "Nursing and Residential Care Facilities"
             },
             new CoreKbIndustry()
             {
                 Id = 96,
                 CoreKbIndustryCategoryID = 16,
                 CoreKbIndustryName = "Social Assistance"
             },
             //******************
             new CoreKbIndustry()
             {
                 Id = 97,
                 CoreKbIndustryCategoryID = 17,
                 CoreKbIndustryName = "Performing Arts, Spectator Sports, and Related Industries"
             },
             new CoreKbIndustry()
             {
                 Id = 98,
                 CoreKbIndustryCategoryID = 17,
                 CoreKbIndustryName = "Museums, Historical Sites, and Similar Institutions"
             },
             new CoreKbIndustry()
             {
                 Id = 99,
                 CoreKbIndustryCategoryID = 17,
                 CoreKbIndustryName = "Amusement, Gambling, and Recreation Industries"
             },
             //**
             new CoreKbIndustry()
             {
                 Id = 100,
                 CoreKbIndustryCategoryID = 18,
                 CoreKbIndustryName = "Accommodation"
             },
             new CoreKbIndustry()
             {
                 Id = 101,
                 CoreKbIndustryCategoryID = 18,
                 CoreKbIndustryName = "Food Services and Drinking Places"
             },
             //*****
             new CoreKbIndustry()
             {
                 Id = 102,
                 CoreKbIndustryCategoryID = 19,
                 CoreKbIndustryName = "Repair and Maintenances"
             },
             new CoreKbIndustry()
             {
                 Id = 103,
                 CoreKbIndustryCategoryID = 19,
                 CoreKbIndustryName = "Personal and Laundry Services"
             },
             new CoreKbIndustry()
             {
                 Id = 104,
                 CoreKbIndustryCategoryID = 19,
                 CoreKbIndustryName = "Religious, Grantmaking, Civic, Professional, and Similar Organizations"
             },
             new CoreKbIndustry()
             {
                 Id = 105,
                 CoreKbIndustryCategoryID = 19,
                 CoreKbIndustryName = "Private Households"
             },
             //******************
             new CoreKbIndustry()
             {
                 Id = 106,
                 CoreKbIndustryCategoryID = 20,
                 CoreKbIndustryName = "Executive, Legislative, and Other General Government Support"
             },
             new CoreKbIndustry()
             {
                 Id = 107,
                 CoreKbIndustryCategoryID = 20,
                 CoreKbIndustryName = "Justice, Public Order, and Safety Activities"
             },
             new CoreKbIndustry()
             {
                 Id = 108,
                 CoreKbIndustryCategoryID = 20,
                 CoreKbIndustryName = "Administration of Human Resource Programs"
             },
             new CoreKbIndustry()
             {
                 Id = 109,
                 CoreKbIndustryCategoryID = 20,
                 CoreKbIndustryName = "Administration of Environmental Quality Programs"
             },
             new CoreKbIndustry()
             {
                 Id = 110,
                 CoreKbIndustryCategoryID = 20,
                 CoreKbIndustryName = "Administration of Housing Programs, Urban Planning, and Community Development "
             },
             new CoreKbIndustry()
             {
                 Id = 111,
                 CoreKbIndustryCategoryID = 20,
                 CoreKbIndustryName = "Administration of Economic Programs "
             },
             new CoreKbIndustry()
             {
                 Id = 112,
                 CoreKbIndustryCategoryID = 20,
                 CoreKbIndustryName = "Space Research and Technology"
             },
             new CoreKbIndustry()
             {
                 Id = 113,
                 CoreKbIndustryCategoryID = 20,
                 CoreKbIndustryName = "National Security and International Affairs"
             });


            base.Configure(builder);
        }
    }
}