﻿// <auto-generated />
using System;
using JuicerLib.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JuicerLib.Migrations
{
    [DbContext(typeof(ItemsDbContext))]
    [Migration("20200414213652_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.3");

            modelBuilder.Entity("JuicerLib.Models.AccessoryModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Accepted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Change")
                        .HasColumnType("REAL");

                    b.Property<long>("Current")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Daily")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Exalted")
                        .HasColumnType("REAL");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .HasColumnType("TEXT");

                    b.Property<string>("Influences")
                        .HasColumnType("TEXT");

                    b.Property<double>("Max")
                        .HasColumnType("REAL");

                    b.Property<double>("Mean")
                        .HasColumnType("REAL");

                    b.Property<double>("Median")
                        .HasColumnType("REAL");

                    b.Property<double>("Min")
                        .HasColumnType("REAL");

                    b.Property<double>("Mode")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<long>("Total")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<string>("Variation")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Accessories");
                });

            modelBuilder.Entity("JuicerLib.Models.ArmourModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Accepted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Change")
                        .HasColumnType("REAL");

                    b.Property<long>("Current")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Daily")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Exalted")
                        .HasColumnType("REAL");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .HasColumnType("TEXT");

                    b.Property<string>("Influences")
                        .HasColumnType("TEXT");

                    b.Property<long?>("LinkCount")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Max")
                        .HasColumnType("REAL");

                    b.Property<double>("Mean")
                        .HasColumnType("REAL");

                    b.Property<double>("Median")
                        .HasColumnType("REAL");

                    b.Property<double>("Min")
                        .HasColumnType("REAL");

                    b.Property<double>("Mode")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<long>("Total")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<string>("Variation")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Armours");
                });

            modelBuilder.Entity("JuicerLib.Models.BaseModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Accepted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("BaseIsElder")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("BaseIsShaper")
                        .HasColumnType("INTEGER");

                    b.Property<long>("BaseItemLevel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Change")
                        .HasColumnType("REAL");

                    b.Property<long>("Current")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Daily")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Exalted")
                        .HasColumnType("REAL");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .HasColumnType("TEXT");

                    b.Property<string>("Influences")
                        .HasColumnType("TEXT");

                    b.Property<double>("Max")
                        .HasColumnType("REAL");

                    b.Property<double>("Mean")
                        .HasColumnType("REAL");

                    b.Property<double>("Median")
                        .HasColumnType("REAL");

                    b.Property<double>("Min")
                        .HasColumnType("REAL");

                    b.Property<double>("Mode")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<long>("Total")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Bases");
                });

            modelBuilder.Entity("JuicerLib.Models.CardModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Accepted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Change")
                        .HasColumnType("REAL");

                    b.Property<long>("Current")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Daily")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Exalted")
                        .HasColumnType("REAL");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .HasColumnType("TEXT");

                    b.Property<double>("Max")
                        .HasColumnType("REAL");

                    b.Property<double>("Mean")
                        .HasColumnType("REAL");

                    b.Property<double>("Median")
                        .HasColumnType("REAL");

                    b.Property<double>("Min")
                        .HasColumnType("REAL");

                    b.Property<double>("Mode")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<long?>("StackSize")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Total")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("JuicerLib.Models.CurrencyModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Accepted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Change")
                        .HasColumnType("REAL");

                    b.Property<long>("Current")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Daily")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Exalted")
                        .HasColumnType("REAL");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .HasColumnType("TEXT");

                    b.Property<double>("Max")
                        .HasColumnType("REAL");

                    b.Property<double>("Mean")
                        .HasColumnType("REAL");

                    b.Property<double>("Median")
                        .HasColumnType("REAL");

                    b.Property<double>("Min")
                        .HasColumnType("REAL");

                    b.Property<double>("Mode")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<long?>("StackSize")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Total")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("JuicerLib.Models.EnchantmentModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Accepted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Change")
                        .HasColumnType("REAL");

                    b.Property<long>("Current")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Daily")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("EnchantMax")
                        .HasColumnType("REAL");

                    b.Property<double?>("EnchantMin")
                        .HasColumnType("REAL");

                    b.Property<double>("Exalted")
                        .HasColumnType("REAL");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .HasColumnType("TEXT");

                    b.Property<string>("Influences")
                        .HasColumnType("TEXT");

                    b.Property<double>("Max")
                        .HasColumnType("REAL");

                    b.Property<double>("Mean")
                        .HasColumnType("REAL");

                    b.Property<double>("Median")
                        .HasColumnType("REAL");

                    b.Property<double>("Min")
                        .HasColumnType("REAL");

                    b.Property<double>("Mode")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<long>("Total")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Enchantments");
                });

            modelBuilder.Entity("JuicerLib.Models.FlaskModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Accepted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Change")
                        .HasColumnType("REAL");

                    b.Property<long>("Current")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Daily")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Exalted")
                        .HasColumnType("REAL");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .HasColumnType("TEXT");

                    b.Property<double>("Max")
                        .HasColumnType("REAL");

                    b.Property<double>("Mean")
                        .HasColumnType("REAL");

                    b.Property<double>("Median")
                        .HasColumnType("REAL");

                    b.Property<double>("Min")
                        .HasColumnType("REAL");

                    b.Property<double>("Mode")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<long>("Total")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<string>("Variation")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Flasks");
                });

            modelBuilder.Entity("JuicerLib.Models.ItemCategoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Display")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("JuicerLib.Models.ItemCategoryModel+Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Display")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ItemCategoryModelId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ItemCategoryModelId");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("JuicerLib.Models.JewelModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Accepted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Change")
                        .HasColumnType("REAL");

                    b.Property<long>("Current")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Daily")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Exalted")
                        .HasColumnType("REAL");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .HasColumnType("TEXT");

                    b.Property<double>("Max")
                        .HasColumnType("REAL");

                    b.Property<double>("Mean")
                        .HasColumnType("REAL");

                    b.Property<double>("Median")
                        .HasColumnType("REAL");

                    b.Property<double>("Min")
                        .HasColumnType("REAL");

                    b.Property<double>("Mode")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<long>("Total")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Jewels");
                });

            modelBuilder.Entity("JuicerLib.Models.MapModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Accepted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Change")
                        .HasColumnType("REAL");

                    b.Property<long>("Current")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Daily")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Exalted")
                        .HasColumnType("REAL");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .HasColumnType("TEXT");

                    b.Property<long?>("MapSeries")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("MapTier")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Max")
                        .HasColumnType("REAL");

                    b.Property<double>("Mean")
                        .HasColumnType("REAL");

                    b.Property<double>("Median")
                        .HasColumnType("REAL");

                    b.Property<double>("Min")
                        .HasColumnType("REAL");

                    b.Property<double>("Mode")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<long>("Total")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Maps");
                });

            modelBuilder.Entity("JuicerLib.Models.ProphecyModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Accepted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Change")
                        .HasColumnType("REAL");

                    b.Property<long>("Current")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Daily")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Exalted")
                        .HasColumnType("REAL");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .HasColumnType("TEXT");

                    b.Property<double>("Max")
                        .HasColumnType("REAL");

                    b.Property<double>("Mean")
                        .HasColumnType("REAL");

                    b.Property<double>("Median")
                        .HasColumnType("REAL");

                    b.Property<double>("Min")
                        .HasColumnType("REAL");

                    b.Property<double>("Mode")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<long>("Total")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Variation")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Prophecies");
                });

            modelBuilder.Entity("JuicerLib.Models.WeaponModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Accepted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Change")
                        .HasColumnType("REAL");

                    b.Property<long>("Current")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Daily")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Exalted")
                        .HasColumnType("REAL");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .HasColumnType("TEXT");

                    b.Property<string>("Influences")
                        .HasColumnType("TEXT");

                    b.Property<long?>("LinkCount")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Max")
                        .HasColumnType("REAL");

                    b.Property<double>("Mean")
                        .HasColumnType("REAL");

                    b.Property<double>("Median")
                        .HasColumnType("REAL");

                    b.Property<double>("Min")
                        .HasColumnType("REAL");

                    b.Property<double>("Mode")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<long>("Total")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<string>("Variation")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("JuicerLib.Models.ItemCategoryModel+Group", b =>
                {
                    b.HasOne("JuicerLib.Models.ItemCategoryModel", null)
                        .WithMany("Groups")
                        .HasForeignKey("ItemCategoryModelId");
                });
#pragma warning restore 612, 618
        }
    }
}