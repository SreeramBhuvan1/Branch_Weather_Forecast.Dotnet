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
    [Migration("20240228085813_stringtodate")]
    partial class stringtodate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.Property<DateOnly>("OPENED_DT")
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
