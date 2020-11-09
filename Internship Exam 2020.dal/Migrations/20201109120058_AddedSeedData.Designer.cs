﻿// <auto-generated />
using System;
using Internship_Exam_2020.dal.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Internship_Exam_2020.dal.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201109120058_AddedSeedData")]
    partial class AddedSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Internship_Exam_2020.dal.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PublishingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Internship_Exam_2020.dal.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 1,
                            CreatedAt = new DateTime(2020, 11, 9, 12, 0, 53, 921, DateTimeKind.Utc).AddTicks(1969),
                            Email = "gcattrall0@cloudflare.com",
                            Name = "Gabriellia"
                        },
                        new
                        {
                            Id = 2,
                            Age = 2,
                            CreatedAt = new DateTime(2020, 11, 9, 12, 0, 53, 922, DateTimeKind.Utc).AddTicks(5067),
                            Email = "gcfdsfattrall0@cloudflare.com",
                            Name = "Gab"
                        },
                        new
                        {
                            Id = 3,
                            Age = 3,
                            CreatedAt = new DateTime(2020, 11, 9, 12, 0, 53, 922, DateTimeKind.Utc).AddTicks(5332),
                            Email = "gcattrall0@cloudfdfsflare.com",
                            Name = "Gabie"
                        },
                        new
                        {
                            Id = 4,
                            Age = 4,
                            CreatedAt = new DateTime(2020, 11, 9, 12, 0, 53, 922, DateTimeKind.Utc).AddTicks(5344),
                            Email = "gcattrallfdf0@cloudflare.com",
                            Name = "John"
                        },
                        new
                        {
                            Id = 5,
                            Age = 6,
                            CreatedAt = new DateTime(2020, 11, 9, 12, 0, 53, 922, DateTimeKind.Utc).AddTicks(5353),
                            Email = "gcattrafdfdll0@cloudflare.com",
                            Name = "Dave"
                        },
                        new
                        {
                            Id = 6,
                            Age = 20,
                            CreatedAt = new DateTime(2020, 11, 9, 12, 0, 53, 922, DateTimeKind.Utc).AddTicks(5363),
                            Email = "gcattrfddall0@cloudflare.com",
                            Name = "Gabriefdfdllia"
                        });
                });

            modelBuilder.Entity("Internship_Exam_2020.dal.Models.Blog", b =>
                {
                    b.HasOne("Internship_Exam_2020.dal.Models.User", "User")
                        .WithMany("Blogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}