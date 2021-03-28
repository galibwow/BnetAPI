﻿// <auto-generated />
using System;
using BnetAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BnetAPI.Migrations
{
    [DbContext(typeof(BnetDbContext))]
    [Migration("20210328104222_Inititalize")]
    partial class Inititalize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BnetAPI.Models.Genres", b =>
                {
                    b.Property<long>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("GenreName")
                        .HasColumnType("bigint");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("BnetAPI.Models.MovieInfo", b =>
                {
                    b.Property<long>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Destination")
                        .HasColumnType("bigint");

                    b.Property<long>("Genreid")
                        .HasColumnType("bigint");

                    b.Property<int>("Imdb_id")
                        .HasColumnType("int");

                    b.Property<string>("MovieName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrginalOverview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriginalTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Originallanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Populerity")
                        .HasColumnType("float");

                    b.Property<string>("PosterPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Release_date")
                        .HasColumnType("datetime2");

                    b.Property<float>("Runtime")
                        .HasColumnType("real");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tagline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("VoteAverage")
                        .HasColumnType("real");

                    b.HasKey("MovieId");

                    b.HasIndex("Genreid");

                    b.ToTable("MovieInfos");
                });

            modelBuilder.Entity("BnetAPI.Models.MovieInfo", b =>
                {
                    b.HasOne("BnetAPI.Models.Genres", "Genres")
                        .WithMany()
                        .HasForeignKey("Genreid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genres");
                });
#pragma warning restore 612, 618
        }
    }
}
