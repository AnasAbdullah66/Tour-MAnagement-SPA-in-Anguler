﻿// <auto-generated />
using System;
using Angular_MasterDetails.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Angular_MasterDetails.Migrations
{
    [DbContext(typeof(BookingDbContext))]
    [Migration("20230219035104_AAA")]
    partial class AAA
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Angular_MasterDetails.Models.BookingEntry", b =>
                {
                    b.Property<int>("BookingEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingEntryId"), 1L, 1);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("SpotId")
                        .HasColumnType("int");

                    b.HasKey("BookingEntryId");

                    b.HasIndex("ClientId");

                    b.HasIndex("SpotId");

                    b.ToTable("BookingEntries");
                });

            modelBuilder.Entity("Angular_MasterDetails.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("ClientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MaritalStatus")
                        .HasColumnType("bit");

                    b.Property<int>("PhoneNo")
                        .HasColumnType("int");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Angular_MasterDetails.Models.Spot", b =>
                {
                    b.Property<int>("SpotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpotId"), 1L, 1);

                    b.Property<string>("SpotName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpotId");

                    b.ToTable("Spots");
                });

            modelBuilder.Entity("Angular_MasterDetails.Models.BookingEntry", b =>
                {
                    b.HasOne("Angular_MasterDetails.Models.Client", "Client")
                        .WithMany("bookingEntries")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Angular_MasterDetails.Models.Spot", "Spot")
                        .WithMany("bookingEntries")
                        .HasForeignKey("SpotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Spot");
                });

            modelBuilder.Entity("Angular_MasterDetails.Models.Client", b =>
                {
                    b.Navigation("bookingEntries");
                });

            modelBuilder.Entity("Angular_MasterDetails.Models.Spot", b =>
                {
                    b.Navigation("bookingEntries");
                });
#pragma warning restore 612, 618
        }
    }
}
