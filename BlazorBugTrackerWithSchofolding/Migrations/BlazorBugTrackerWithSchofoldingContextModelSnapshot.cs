﻿// <auto-generated />
using System;
using BlazorBugTrackerWithSchofolding.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorBugTrackerWithSchofolding.Migrations
{
    [DbContext(typeof(BlazorBugTrackerWithSchofoldingContext))]
    partial class BlazorBugTrackerWithSchofoldingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("BlazorBugTrackerWithSchofolding.Models.Bug", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AssignedTo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Reporter")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StepsToReproduce")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Bug");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Bug");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("BlazorBugTrackerWithSchofolding.Models.UserStory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AcceptanceCriteria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AsA")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AssignedTo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("IWant")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Points")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Reporter")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SoThat")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserStory");
                });

            modelBuilder.Entity("BlazorBugTrackerWithSchofolding.Models.Defect", b =>
                {
                    b.HasBaseType("BlazorBugTrackerWithSchofolding.Models.Bug");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Environment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FoundInVersion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Defect");
                });
#pragma warning restore 612, 618
        }
    }
}