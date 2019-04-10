﻿// <auto-generated />
using System;
using EFCoreCodeFirstSample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SoccerCourtReserve.Migrations
{
    [DbContext(typeof(CourtReserveContext))]
    [Migration("20190408203942_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreCodeFirstSample.Models.Court", b =>
                {
                    b.Property<int>("CourtId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Number");

                    b.Property<string>("Size");

                    b.Property<string>("Type");

                    b.HasKey("CourtId");

                    b.ToTable("Court");
                });

            modelBuilder.Entity("EFCoreCodeFirstSample.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Document");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("PersonId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("EFCoreCodeFirstSample.Models.Reserve", b =>
                {
                    b.Property<int>("ReserveId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourtsCourtId");

                    b.Property<int?>("PersonId");

                    b.Property<DateTime>("ReserveEnd");

                    b.Property<DateTime>("ReserveStart");

                    b.HasKey("ReserveId");

                    b.HasIndex("CourtsCourtId");

                    b.HasIndex("PersonId");

                    b.ToTable("Reserve");
                });

            modelBuilder.Entity("EFCoreCodeFirstSample.Models.Reserve", b =>
                {
                    b.HasOne("EFCoreCodeFirstSample.Models.Court", "Courts")
                        .WithMany()
                        .HasForeignKey("CourtsCourtId");

                    b.HasOne("EFCoreCodeFirstSample.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");
                });
#pragma warning restore 612, 618
        }
    }
}
