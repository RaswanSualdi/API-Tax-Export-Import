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
    [Migration("20231203200051_NewMigration2")]
    partial class NewMigration2
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
                });

            modelBuilder.Entity("WebApplication2.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int?>("Countryid")
                        .HasColumnType("integer");

                    b.Property<int?>("Transactionid")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("Countryid");

                    b.HasIndex("Transactionid");

                    b.ToTable("Products");
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

                    b.Property<long>("finalPrice")
                        .HasColumnType("bigint");

                    b.Property<long>("price")
                        .HasColumnType("bigint");

                    b.Property<decimal>("tariff")
                        .HasColumnType("numeric");

                    b.HasKey("id");

                    b.ToTable("Transactions");
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

                    b.HasOne("WebApplication2.Models.Transaction", null)
                        .WithMany("Products")
                        .HasForeignKey("Transactionid");
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
