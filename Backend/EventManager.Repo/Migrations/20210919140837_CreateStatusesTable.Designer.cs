﻿// <auto-generated />
using System;
using EventManager.Repo.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventManager.Repo.Migrations
{
    [DbContext(typeof(EventManageContext))]
    [Migration("20210919140837_CreateStatusesTable")]
    partial class CreateStatusesTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EventManager.Domain.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("EventManager.Domain.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PositionType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EventManager.Domain.Models.EmployeeGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("EventManagementId")
                        .HasColumnType("int");

                    b.Property<int?>("GatheringAddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("GatheringTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("Hours")
                        .HasColumnType("float");

                    b.Property<int>("PositionType")
                        .HasColumnType("int");

                    b.Property<double>("salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("EventManagementId");

                    b.HasIndex("GatheringAddressId");

                    b.ToTable("EmployeeGroups");
                });

            modelBuilder.Entity("EventManager.Domain.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EventAddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poster")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EventAddressId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("EventManager.Domain.Models.EventManagement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EventId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("EventManagements");
                });

            modelBuilder.Entity("EventManager.Domain.Models.JobOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EventId")
                        .HasColumnType("int");

                    b.Property<double>("Hour")
                        .HasColumnType("float");

                    b.Property<int>("PositionType")
                        .HasColumnType("int");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("JobOffers");
                });

            modelBuilder.Entity("EventManager.Domain.Models.JobOfferStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("JobOfferId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("JobOfferId");

                    b.ToTable("JobOfferStatuses");
                });

            modelBuilder.Entity("EventManager.Domain.Models.EmployeeGroup", b =>
                {
                    b.HasOne("EventManager.Domain.Models.EventManagement", null)
                        .WithMany("EmplyeeGroups")
                        .HasForeignKey("EventManagementId");

                    b.HasOne("EventManager.Domain.Models.Address", "GatheringAddress")
                        .WithMany()
                        .HasForeignKey("GatheringAddressId");

                    b.Navigation("GatheringAddress");
                });

            modelBuilder.Entity("EventManager.Domain.Models.Event", b =>
                {
                    b.HasOne("EventManager.Domain.Models.Address", "EventAddress")
                        .WithMany()
                        .HasForeignKey("EventAddressId");

                    b.Navigation("EventAddress");
                });

            modelBuilder.Entity("EventManager.Domain.Models.EventManagement", b =>
                {
                    b.HasOne("EventManager.Domain.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("EventManager.Domain.Models.JobOffer", b =>
                {
                    b.HasOne("EventManager.Domain.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("EventManager.Domain.Models.JobOfferStatus", b =>
                {
                    b.HasOne("EventManager.Domain.Models.Employee", "Employee")
                        .WithMany("OfferStatuses")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("EventManager.Domain.Models.JobOffer", "JobOffer")
                        .WithMany()
                        .HasForeignKey("JobOfferId");

                    b.Navigation("Employee");

                    b.Navigation("JobOffer");
                });

            modelBuilder.Entity("EventManager.Domain.Models.Employee", b =>
                {
                    b.Navigation("OfferStatuses");
                });

            modelBuilder.Entity("EventManager.Domain.Models.EventManagement", b =>
                {
                    b.Navigation("EmplyeeGroups");
                });
#pragma warning restore 612, 618
        }
    }
}