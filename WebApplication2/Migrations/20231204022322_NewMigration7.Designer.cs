﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApplication2.Database;

#nullable disable

namespace WebApplication2.Migrations
{
    [DbContext(typeof(WebApplication2Context))]
    [Migration("20231204022322_NewMigration7")]
    partial class NewMigration7
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebApplication2.Models.Country", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            id = 1,
                            code = "ID",
                            name = "Indonesia"
                        },
                        new
                        {
                            id = 2,
                            code = "SG",
                            name = "Singapore"
                        },
                        new
                        {
                            id = 3,
                            code = "MY",
                            name = "Malaysia"
                        },
                        new
                        {
                            id = 4,
                            code = "TH",
                            name = "Thailand"
                        },
                        new
                        {
                            id = 5,
                            code = "VN",
                            name = "Vietnam"
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.Harbor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("countryId")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("countryId");

                    b.ToTable("Harbors");

                    b.HasData(
                        new
                        {
                            id = 1,
                            code = "MAK",
                            countryId = 1,
                            name = "Makassar"
                        },
                        new
                        {
                            id = 2,
                            code = "BIT",
                            countryId = 1,
                            name = "Bitung"
                        },
                        new
                        {
                            id = 3,
                            code = "JUR",
                            countryId = 2,
                            name = "Jurong"
                        },
                        new
                        {
                            id = 4,
                            code = "KLA",
                            countryId = 3,
                            name = "Klang"
                        },
                        new
                        {
                            id = 5,
                            code = "BAN",
                            countryId = 4,
                            name = "Bangkok"
                        },
                        new
                        {
                            id = 6,
                            code = "HAI",
                            countryId = 5,
                            name = "Hai Phong"
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int?>("Countryid")
                        .HasColumnType("integer");

                    b.Property<int>("TransactionId")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("Countryid");

                    b.HasIndex("TransactionId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            id = 1,
                            TransactionId = 1,
                            name = "Product1"
                        },
                        new
                        {
                            id = 2,
                            TransactionId = 1,
                            name = "Product2"
                        },
                        new
                        {
                            id = 3,
                            TransactionId = 2,
                            name = "Product3"
                        },
                        new
                        {
                            id = 4,
                            TransactionId = 2,
                            name = "Product4"
                        },
                        new
                        {
                            id = 5,
                            TransactionId = 3,
                            name = "Product5"
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.Transaction", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal?>("price")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("tariff")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("tariffPrice")
                        .HasColumnType("numeric");

                    b.HasKey("id");

                    b.ToTable("Transactions");

                    b.HasData(
                        new
                        {
                            id = 1,
                            code = "T001",
                            tariff = 10.0m
                        },
                        new
                        {
                            id = 2,
                            code = "T002",
                            tariff = 20.2m
                        },
                        new
                        {
                            id = 3,
                            code = "T003",
                            tariff = 0.15m
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.Harbor", b =>
                {
                    b.HasOne("WebApplication2.Models.Country", "country")
                        .WithMany("Harbors")
                        .HasForeignKey("countryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("country");
                });

            modelBuilder.Entity("WebApplication2.Models.Product", b =>
                {
                    b.HasOne("WebApplication2.Models.Country", null)
                        .WithMany("Products")
                        .HasForeignKey("Countryid");

                    b.HasOne("WebApplication2.Models.Transaction", "Transaction")
                        .WithMany("Products")
                        .HasForeignKey("TransactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("WebApplication2.Models.Country", b =>
                {
                    b.Navigation("Harbors");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("WebApplication2.Models.Transaction", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
