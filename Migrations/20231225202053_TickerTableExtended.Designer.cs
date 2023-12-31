﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YahooFinanceAgregator.Domain;

#nullable disable

namespace YahooFinanceAgregator.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231225202053_TickerTableExtended")]
    partial class TickerTableExtended
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("YahooFinanceAgregator.Domain.Ticker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FoundedYear")
                        .HasColumnType("int");

                    b.Property<long>("MarketCap")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfEmployees")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tickers");
                });

            modelBuilder.Entity("YahooFinanceAgregator.Domain.TickerHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("ClosePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OpenPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TickerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TickerId");

                    b.ToTable("TickerHistory");
                });

            modelBuilder.Entity("YahooFinanceAgregator.Domain.TickerHistory", b =>
                {
                    b.HasOne("YahooFinanceAgregator.Domain.Ticker", "Ticker")
                        .WithMany()
                        .HasForeignKey("TickerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ticker");
                });
#pragma warning restore 612, 618
        }
    }
}
