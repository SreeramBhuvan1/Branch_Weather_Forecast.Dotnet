﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Task1.Data;

#nullable disable

namespace Task1.Migrations
{
    [DbContext(typeof(Task1DbContext))]
    [Migration("20240228112117_added")]
    partial class added
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.HasData(
                        new
                        {
                            Id = "c7b837bd-b975-41df-8e30-a3b5cc1a6a56",
                            Name = "Administraton",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2f570a9e-fcfb-4e4b-be30-be19c34baa65",
                            Name = "User",
                            NormalizedName = "USER"
                        });
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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Task1.Data.ApiUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                });

            modelBuilder.Entity("Task1.Data.StateTable", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CITY")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COUNTRY_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CURRENCY")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STATE_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("stateTables");

                    b.HasData(
                        new
                        {
                            ID = 100,
                            CITY = "EDMONTON",
                            COUNTRY_NAME = "Canada",
                            CURRENCY = "CAD",
                            STATE_NAME = "Alberta"
                        },
                        new
                        {
                            ID = 101,
                            CITY = "ACHESON",
                            COUNTRY_NAME = "Canada",
                            CURRENCY = "CAD",
                            STATE_NAME = "Alberta"
                        },
                        new
                        {
                            ID = 102,
                            CITY = "AIRDRIE",
                            COUNTRY_NAME = "Canada",
                            CURRENCY = "CAD",
                            STATE_NAME = "Alberta"
                        },
                        new
                        {
                            ID = 103,
                            CITY = "CALGARY",
                            COUNTRY_NAME = "Canada",
                            CURRENCY = "CAD",
                            STATE_NAME = "Alberta"
                        },
                        new
                        {
                            ID = 104,
                            CITY = "GRANDE PRAIRIE",
                            COUNTRY_NAME = "Canada",
                            CURRENCY = "CAD",
                            STATE_NAME = "Alberta"
                        },
                        new
                        {
                            ID = 105,
                            CITY = "NISKU",
                            COUNTRY_NAME = "Canada",
                            CURRENCY = "CAD",
                            STATE_NAME = "Alberta"
                        },
                        new
                        {
                            ID = 106,
                            CITY = "LLOYDMINSTER",
                            COUNTRY_NAME = "Canada",
                            CURRENCY = "CAD",
                            STATE_NAME = "Alberta"
                        },
                        new
                        {
                            ID = 107,
                            CITY = "MEDICINE HAT",
                            COUNTRY_NAME = "Canada",
                            CURRENCY = "CAD",
                            STATE_NAME = "Alberta"
                        },
                        new
                        {
                            ID = 108,
                            CITY = "RED DEER",
                            COUNTRY_NAME = "Canada",
                            CURRENCY = "CAD",
                            STATE_NAME = "Alberta"
                        },
                        new
                        {
                            ID = 109,
                            CITY = "WHITECOURT",
                            COUNTRY_NAME = "Canada",
                            CURRENCY = "CAD",
                            STATE_NAME = "Alberta"
                        },
                        new
                        {
                            ID = 110,
                            CITY = "ANCHORAGE",
                            COUNTRY_NAME = "United States",
                            CURRENCY = "USD",
                            STATE_NAME = "Alaska"
                        },
                        new
                        {
                            ID = 111,
                            CITY = "FAIRBANKS",
                            COUNTRY_NAME = "United States",
                            CURRENCY = "USD",
                            STATE_NAME = "Alaska"
                        });
                });

            modelBuilder.Entity("Task1.Data.sampledata", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ADDRESS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BUSINESS_HOURS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BU_CODES")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CITYID")
                        .HasColumnType("int");

                    b.Property<int>("LATITUDE")
                        .HasColumnType("int");

                    b.Property<int>("LONGITUDE")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("OPENED_DT")
                        .HasColumnType("date");

                    b.Property<string>("PHONE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STATUS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CITYID");

                    b.ToTable("SampleData");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ADDRESS = "19020   111th Ave",
                            BUSINESS_HOURS = "Monday - Friday 7:30am - 5:00pm",
                            BU_CODES = "AB100",
                            CITYID = 100,
                            LATITUDE = 54,
                            LONGITUDE = -114,
                            OPENED_DT = new DateOnly(2008, 9, 15),
                            PHONE = "780-801-5006",
                            STATUS = "Open"
                        });
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
                    b.HasOne("Task1.Data.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Task1.Data.ApiUser", null)
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

                    b.HasOne("Task1.Data.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Task1.Data.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Task1.Data.sampledata", b =>
                {
                    b.HasOne("Task1.Data.StateTable", "state")
                        .WithMany("sampledata")
                        .HasForeignKey("CITYID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("state");
                });

            modelBuilder.Entity("Task1.Data.StateTable", b =>
                {
                    b.Navigation("sampledata");
                });
#pragma warning restore 612, 618
        }
    }
}