﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp1_SkillsBank.Models;

namespace WebApp1_SkillsBank.Migrations
{
    [DbContext(typeof(SkillsBankContext))]
    [Migration("20220821113405_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApp1_SkillsBank.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("categoryName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WebApp1_SkillsBank.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ApplicationDueDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("CertAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("CrsPromoLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CrsReferenceText")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CrsReleasedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CrsRequirement")
                        .HasColumnType("int");

                    b.Property<string>("CrsStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiscountPercent")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("SearchTags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sessions")
                        .HasColumnType("int");

                    b.Property<DateTime>("TotalHours")
                        .HasColumnType("datetime2");

                    b.Property<int>("categoryFK")
                        .HasColumnType("int");

                    b.Property<int>("crsLevelFK")
                        .HasColumnType("int");

                    b.Property<int>("crsTypeFK")
                        .HasColumnType("int");

                    b.Property<int>("currencyFK")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("duration")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("languageFK")
                        .HasColumnType("int");

                    b.Property<int>("maxStudents")
                        .HasColumnType("int");

                    b.Property<int>("minStudents")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CrsReferenceText")
                        .IsUnique()
                        .HasFilter("[CrsReferenceText] IS NOT NULL");

                    b.HasIndex("categoryFK");

                    b.HasIndex("crsLevelFK");

                    b.HasIndex("crsTypeFK");

                    b.HasIndex("currencyFK");

                    b.HasIndex("languageFK");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("WebApp1_SkillsBank.Models.CrsLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("levelName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CrsLevels");
                });

            modelBuilder.Entity("WebApp1_SkillsBank.Models.CrsSkills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CrsFK")
                        .HasColumnType("int");

                    b.Property<string>("skillName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CrsFK");

                    b.ToTable("CrsSkills");
                });

            modelBuilder.Entity("WebApp1_SkillsBank.Models.CrsType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("typeValue")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CrsTypes");
                });

            modelBuilder.Entity("WebApp1_SkillsBank.Models.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("currencyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("WebApp1_SkillsBank.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LangName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("WebApp1_SkillsBank.Models.Course", b =>
                {
                    b.HasOne("WebApp1_SkillsBank.Models.Category", "category")
                        .WithMany()
                        .HasForeignKey("categoryFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp1_SkillsBank.Models.CrsLevel", "crsLevel")
                        .WithMany()
                        .HasForeignKey("crsLevelFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp1_SkillsBank.Models.CrsType", "crsType")
                        .WithMany()
                        .HasForeignKey("crsTypeFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp1_SkillsBank.Models.Currency", "currency")
                        .WithMany()
                        .HasForeignKey("currencyFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp1_SkillsBank.Models.Language", "language")
                        .WithMany()
                        .HasForeignKey("languageFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApp1_SkillsBank.Models.CrsSkills", b =>
                {
                    b.HasOne("WebApp1_SkillsBank.Models.Course", "course")
                        .WithMany("crsSkill")
                        .HasForeignKey("CrsFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
