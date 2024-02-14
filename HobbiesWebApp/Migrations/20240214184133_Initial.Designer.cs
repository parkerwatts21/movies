﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission07_Watts.Models;

#nullable disable

namespace Mission07_Watts.Migrations
{
    [DbContext(typeof(MovieApplicationContext))]
    [Migration("20240214184133_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Mission07_Watts.Models.Application", b =>
                {
                    b.Property<int>("movieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("movieCategory")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("movieDirector")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("movieEdited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("movieLent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("movieNotes")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("movieRating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("movieTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("movieYear")
                        .HasColumnType("INTEGER");

                    b.HasKey("movieID");

                    b.ToTable("Applications");
                });
#pragma warning restore 612, 618
        }
    }
}
