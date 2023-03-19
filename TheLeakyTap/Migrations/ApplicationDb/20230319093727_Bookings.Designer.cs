﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheLeakyTap.Data;

#nullable disable

namespace TheLeakyTap.Migrations.ApplicationDb
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230319093727_Bookings")]
    partial class Bookings
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("TheLeakyTap.Models.Booking", b =>
                {
                    b.Property<int>("bookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("bookingDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("bookingGuests")
                        .HasColumnType("INTEGER");

                    b.Property<string>("bookingName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("bookingNotes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("bookingType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("bookingID");

                    b.ToTable("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
