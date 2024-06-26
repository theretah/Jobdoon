﻿// <auto-generated />
using System;
using Jobdoon.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jobdoon.Migrations
{
    [DbContext(typeof(JobdoonContext))]
    [Migration("20240307065731_PopulatingRequestStatesTable")]
    partial class PopulatingRequestStatesTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Jobdoon.Models.Entities.Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("EmployerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LatinName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("LogoImage")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PersianName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonnelCountId")
                        .HasColumnType("int");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PersonnelCountId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.Degree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Degrees");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.MilitaryService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MilitaryServices");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.Opportunity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DegreeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExperienceId")
                        .HasColumnType("int");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<int>("MilitaryServiceId")
                        .HasColumnType("int");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UnspecifiedSalaryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DegreeId");

                    b.HasIndex("ExperienceId");

                    b.HasIndex("MilitaryServiceId");

                    b.ToTable("Opportunities");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.PersonnelCount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PersonnelCounts");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("OpportunityId")
                        .HasColumnType("int");

                    b.Property<int>("RequestStateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("OpportunityId");

                    b.HasIndex("RequestStateId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.RequestState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RequestStates");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.Save", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("OpportunityId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId", "OpportunityId");

                    b.HasIndex("OpportunityId");

                    b.ToTable("Saves");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.UnspecifiedSalary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UnspecifiedSalaries");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("DegreeId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GenderId")
                        .HasColumnType("int");

                    b.Property<bool>("IsEmployer")
                        .HasColumnType("bit");

                    b.Property<int?>("MilitaryServiceId")
                        .HasColumnType("int");

                    b.Property<byte[]>("ProfileImage")
                        .HasColumnType("varbinary(max)");

                    b.HasIndex("CompanyId")
                        .IsUnique()
                        .HasFilter("[CompanyId] IS NOT NULL");

                    b.HasIndex("DegreeId");

                    b.HasIndex("GenderId");

                    b.HasIndex("MilitaryServiceId");

                    b.HasDiscriminator().HasValue("AppUser");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.Company", b =>
                {
                    b.HasOne("Jobdoon.Models.Entities.Category", "Category")
                        .WithMany("Companies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jobdoon.Models.Entities.PersonnelCount", "PersonnelCount")
                        .WithMany("Companies")
                        .HasForeignKey("PersonnelCountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("PersonnelCount");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.Opportunity", b =>
                {
                    b.HasOne("Jobdoon.Models.Entities.Degree", "Degree")
                        .WithMany("Opportunities")
                        .HasForeignKey("DegreeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jobdoon.Models.Entities.Assignment", "Assignment")
                        .WithMany("Opportunities")
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jobdoon.Models.Entities.Category", "Category")
                        .WithMany("Opportunities")
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jobdoon.Models.Entities.Experience", "Experience")
                        .WithMany("Opportunities")
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jobdoon.Models.Entities.Gender", "Gender")
                        .WithMany("Opportunities")
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jobdoon.Models.Entities.Province", "Province")
                        .WithMany("Opportunities")
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jobdoon.Models.Entities.UnspecifiedSalary", "UnspecifiedSalary")
                        .WithMany("Opportunities")
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jobdoon.Models.Entities.MilitaryService", "MilitaryService")
                        .WithMany("Opportunities")
                        .HasForeignKey("MilitaryServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");

                    b.Navigation("Category");

                    b.Navigation("Degree");

                    b.Navigation("Experience");

                    b.Navigation("Gender");

                    b.Navigation("MilitaryService");

                    b.Navigation("Province");

                    b.Navigation("UnspecifiedSalary");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.Request", b =>
                {
                    b.HasOne("Jobdoon.Models.Entities.AppUser", "Employee")
                        .WithMany("Requests")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Jobdoon.Models.Entities.Opportunity", "Opportunity")
                        .WithMany("Requests")
                        .HasForeignKey("OpportunityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Jobdoon.Models.Entities.RequestState", "RequestState")
                        .WithMany("Requests")
                        .HasForeignKey("RequestStateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Opportunity");

                    b.Navigation("RequestState");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.Save", b =>
                {
                    b.HasOne("Jobdoon.Models.Entities.AppUser", "Employee")
                        .WithMany("Saves")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Jobdoon.Models.Entities.Opportunity", "Opportunity")
                        .WithMany("Saves")
                        .HasForeignKey("OpportunityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Opportunity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.AppUser", b =>
                {
                    b.HasOne("Jobdoon.Models.Entities.Company", "Company")
                        .WithOne("Employer")
                        .HasForeignKey("Jobdoon.Models.Entities.AppUser", "CompanyId");

                    b.HasOne("Jobdoon.Models.Entities.Degree", "Degree")
                        .WithMany("Employees")
                        .HasForeignKey("DegreeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jobdoon.Models.Entities.Gender", "Gender")
                        .WithMany("Employees")
                        .HasForeignKey("GenderId");

                    b.HasOne("Jobdoon.Models.Entities.MilitaryService", "MilitaryService")
                        .WithMany("Employees")
                        .HasForeignKey("MilitaryServiceId");

                    b.Navigation("Company");

                    b.Navigation("Degree");

                    b.Navigation("Gender");

                    b.Navigation("MilitaryService");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.Assignment", b =>
                {
                    b.Navigation("Opportunities");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.Category", b =>
                {
                    b.Navigation("Companies");

                    b.Navigation("Opportunities");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.Company", b =>
                {
                    b.Navigation("Employer")
                        .IsRequired();
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.Degree", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Opportunities");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.Experience", b =>
                {
                    b.Navigation("Opportunities");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.Gender", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Opportunities");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.MilitaryService", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Opportunities");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.Opportunity", b =>
                {
                    b.Navigation("Requests");

                    b.Navigation("Saves");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.PersonnelCount", b =>
                {
                    b.Navigation("Companies");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.Province", b =>
                {
                    b.Navigation("Opportunities");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.RequestState", b =>
                {
                    b.Navigation("Requests");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.UnspecifiedSalary", b =>
                {
                    b.Navigation("Opportunities");
                });

            modelBuilder.Entity("Jobdoon.Models.Entities.AppUser", b =>
                {
                    b.Navigation("Requests");

                    b.Navigation("Saves");
                });
#pragma warning restore 612, 618
        }
    }
}
