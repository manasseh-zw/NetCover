﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCover.Server.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace NetCover.Server.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20240604092025_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("NetCover.Server.Data.CellTowerModel", b =>
                {
                    b.Property<int>("CID")
                        .HasColumnType("integer");

                    b.Property<int>("LAC")
                        .HasColumnType("integer");

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<int>("MCC")
                        .HasColumnType("integer");

                    b.Property<int>("MNC")
                        .HasColumnType("integer");

                    b.Property<string>("Radio")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasIndex("MNC");

                    b.ToTable("CellTowers");
                });
#pragma warning restore 612, 618
        }
    }
}