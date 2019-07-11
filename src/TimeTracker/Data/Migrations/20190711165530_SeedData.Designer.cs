﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimeTracker.Data;

namespace TimeTracker.Data.Migrations
{
    [DbContext(typeof(TimeTrackerDbContext))]
    [Migration("20190711165530_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview6.19304.10");

            modelBuilder.Entity("TimeTracker.Domain.Client", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            id = 1L,
                            name = "Client 1"
                        },
                        new
                        {
                            id = 2L,
                            name = "Client 2"
                        });
                });

            modelBuilder.Entity("TimeTracker.Domain.Project", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Clientid");

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("id");

                    b.HasIndex("Clientid");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            id = 1L,
                            Clientid = 1L,
                            name = "Project 1"
                        },
                        new
                        {
                            id = 2L,
                            Clientid = 1L,
                            name = "Project 2"
                        },
                        new
                        {
                            id = 3L,
                            Clientid = 2L,
                            name = "Project 3"
                        });
                });

            modelBuilder.Entity("TimeTracker.Domain.TimeEntry", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<DateTime>("EntryDate");

                    b.Property<decimal>("HourRate");

                    b.Property<int>("Hours");

                    b.Property<long>("Projectid");

                    b.Property<long>("Userid");

                    b.HasKey("id");

                    b.HasIndex("Projectid");

                    b.HasIndex("Userid");

                    b.ToTable("TimeEntries");
                });

            modelBuilder.Entity("TimeTracker.Domain.User", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("HourRate");

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            id = 1L,
                            HourRate = 15m,
                            name = "User 1"
                        },
                        new
                        {
                            id = 2L,
                            HourRate = 20m,
                            name = "User 2"
                        });
                });

            modelBuilder.Entity("TimeTracker.Domain.Project", b =>
                {
                    b.HasOne("TimeTracker.Domain.Client", "Client")
                        .WithMany()
                        .HasForeignKey("Clientid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TimeTracker.Domain.TimeEntry", b =>
                {
                    b.HasOne("TimeTracker.Domain.Project", "Project")
                        .WithMany()
                        .HasForeignKey("Projectid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TimeTracker.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("Userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
