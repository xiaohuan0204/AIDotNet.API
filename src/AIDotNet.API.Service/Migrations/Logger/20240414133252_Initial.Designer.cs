﻿// <auto-generated />
using System;
using AIDotNet.API.Service.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AIDotNet.API.Service.Migrations.Logger
{
    [DbContext(typeof(LoggerDbContext))]
    [Migration("20240414133252_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("AIDotNet.API.Service.Domain.ChatLogger", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ChannelId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChannelName")
                        .HasColumnType("TEXT");

                    b.Property<int>("CompletionTokens")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Creator")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Modifier")
                        .HasColumnType("TEXT");

                    b.Property<int>("PromptTokens")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quota")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TokenName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Creator");

                    b.HasIndex("ModelName");

                    b.HasIndex("TokenName");

                    b.HasIndex("UserName");

                    b.ToTable("Loggers");
                });

            modelBuilder.Entity("AIDotNet.API.Service.Domain.ModelStatisticsNumber", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Creator")
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Day")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Modifier")
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Month")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quota")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TokenUsed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Creator");

                    b.HasIndex("Day");

                    b.HasIndex("ModelName");

                    b.HasIndex("Month");

                    b.HasIndex("Year");

                    b.ToTable("ModelStatisticsNumbers");
                });

            modelBuilder.Entity("AIDotNet.API.Service.Domain.StatisticsConsumesNumber", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Creator")
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Day")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Modifier")
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Month")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Number")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<long>("Value")
                        .HasColumnType("INTEGER");

                    b.Property<ushort>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Creator");

                    b.HasIndex("Day");

                    b.HasIndex("Month");

                    b.HasIndex("Year");

                    b.ToTable("StatisticsConsumesNumbers");
                });
#pragma warning restore 612, 618
        }
    }
}
