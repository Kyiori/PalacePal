﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pal.Server;

#nullable disable

namespace Pal.Server.Migrations
{
    [DbContext(typeof(PalContext))]
    partial class PalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("Pal.Server.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("IpHash")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Pal.Server.GlobalSetting", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.HasKey("Key");

                    b.ToTable("GlobalSettings");
                });

            modelBuilder.Entity("Pal.Server.PalaceLocation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<ushort>("TerritoryType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<float>("X")
                        .HasColumnType("REAL");

                    b.Property<float>("Y")
                        .HasColumnType("REAL");

                    b.Property<float>("Z")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });
#pragma warning restore 612, 618
        }
    }
}
