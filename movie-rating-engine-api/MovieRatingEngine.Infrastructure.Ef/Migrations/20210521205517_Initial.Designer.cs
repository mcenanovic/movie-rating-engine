﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieRatingEngine.Infrastructure.Ef;

namespace MovieRatingEngine.Infrastructure.Ef.Migrations
{
    [DbContext(typeof(MovieRatingEngineDbContext))]
    [Migration("20210521205517_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieRatingEngine.Infrastructure.Ef.Entities.Actor", b =>
                {
                    b.Property<int>("ActorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ActorID");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            ActorID = 1,
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            ActorID = 2,
                            FirstName = "Edin",
                            LastName = "Dzeko"
                        },
                        new
                        {
                            ActorID = 3,
                            FirstName = "Dino",
                            LastName = "Merlin"
                        },
                        new
                        {
                            ActorID = 4,
                            FirstName = "Denzel",
                            LastName = "Washington"
                        },
                        new
                        {
                            ActorID = 5,
                            FirstName = "Jason",
                            LastName = "Statham"
                        },
                        new
                        {
                            ActorID = 6,
                            FirstName = "Tom",
                            LastName = "Cruz"
                        },
                        new
                        {
                            ActorID = 7,
                            FirstName = "David",
                            LastName = "Suchet"
                        },
                        new
                        {
                            ActorID = 8,
                            FirstName = "Tom",
                            LastName = "Hanks"
                        });
                });

            modelBuilder.Entity("MovieRatingEngine.Infrastructure.Ef.Entities.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMovie")
                        .HasColumnType("bit");

                    b.Property<decimal>("Rating")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(3, 2)
                        .HasColumnType("decimal(3,2)")
                        .HasDefaultValue(0m);

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("VoteCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("MovieID");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Description = "Description of movie 1",
                            ImageName = "1.png",
                            IsMovie = true,
                            Rating = 3m,
                            ReleaseDate = new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Movie 1",
                            VoteCount = 1
                        },
                        new
                        {
                            MovieID = 2,
                            Description = "Description of movie 2",
                            ImageName = "2.png",
                            IsMovie = true,
                            Rating = 4m,
                            ReleaseDate = new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Movie 2",
                            VoteCount = 1
                        },
                        new
                        {
                            MovieID = 3,
                            Description = "Description of movie 3",
                            IsMovie = true,
                            Rating = 3.5m,
                            ReleaseDate = new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Movie 3",
                            VoteCount = 3
                        },
                        new
                        {
                            MovieID = 4,
                            Description = "Description of movie 4",
                            ImageName = "4.png",
                            IsMovie = true,
                            Rating = 4.5m,
                            ReleaseDate = new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Movie 4",
                            VoteCount = 2
                        },
                        new
                        {
                            MovieID = 5,
                            Description = "Description of TV Show 5",
                            ImageName = "5.png",
                            IsMovie = false,
                            Rating = 2.4m,
                            ReleaseDate = new DateTime(2005, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "TV Show 5",
                            VoteCount = 5
                        },
                        new
                        {
                            MovieID = 6,
                            Description = "Description of TV Show 6",
                            ImageName = "6.png",
                            IsMovie = false,
                            Rating = 3.4m,
                            ReleaseDate = new DateTime(2012, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "TV Show 6",
                            VoteCount = 2
                        },
                        new
                        {
                            MovieID = 7,
                            Description = "Description of movie 7",
                            ImageName = "7.png",
                            IsMovie = true,
                            Rating = 4.4m,
                            ReleaseDate = new DateTime(2015, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Movie 7",
                            VoteCount = 5
                        },
                        new
                        {
                            MovieID = 8,
                            Description = "Description of movie 8",
                            ImageName = "8.png",
                            IsMovie = true,
                            Rating = 2.4m,
                            ReleaseDate = new DateTime(2000, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Movie 8",
                            VoteCount = 5
                        },
                        new
                        {
                            MovieID = 9,
                            Description = "Description of movie 9",
                            ImageName = "9.png",
                            IsMovie = true,
                            Rating = 4.1m,
                            ReleaseDate = new DateTime(2007, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Movie 9",
                            VoteCount = 3
                        },
                        new
                        {
                            MovieID = 10,
                            Description = "Description of movie 10",
                            ImageName = "10.png",
                            IsMovie = true,
                            Rating = 3.0m,
                            ReleaseDate = new DateTime(2019, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Movie 10",
                            VoteCount = 1
                        },
                        new
                        {
                            MovieID = 11,
                            Description = "Description of movie 11",
                            ImageName = "11.png",
                            IsMovie = true,
                            Rating = 3.5m,
                            ReleaseDate = new DateTime(2017, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Movie 11",
                            VoteCount = 2
                        },
                        new
                        {
                            MovieID = 12,
                            Description = "Description of movie 12",
                            ImageName = "12.png",
                            IsMovie = true,
                            Rating = 2.7m,
                            ReleaseDate = new DateTime(2014, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Movie 12",
                            VoteCount = 3
                        },
                        new
                        {
                            MovieID = 13,
                            Description = "Description of movie 13",
                            ImageName = "13.png",
                            IsMovie = true,
                            Rating = 4.7m,
                            ReleaseDate = new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Movie 13",
                            VoteCount = 3
                        },
                        new
                        {
                            MovieID = 14,
                            Description = "Description of movie 14",
                            ImageName = "14.png",
                            IsMovie = true,
                            Rating = 5.0m,
                            ReleaseDate = new DateTime(2016, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Movie 14",
                            VoteCount = 4
                        });
                });

            modelBuilder.Entity("MovieRatingEngine.Infrastructure.Ef.Entities.MovieActor", b =>
                {
                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.Property<int>("ActorID")
                        .HasColumnType("int");

                    b.HasKey("MovieID", "ActorID");

                    b.HasIndex("ActorID");

                    b.ToTable("MovieActors");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            ActorID = 1
                        },
                        new
                        {
                            MovieID = 1,
                            ActorID = 2
                        },
                        new
                        {
                            MovieID = 1,
                            ActorID = 3
                        },
                        new
                        {
                            MovieID = 2,
                            ActorID = 1
                        },
                        new
                        {
                            MovieID = 3,
                            ActorID = 3
                        },
                        new
                        {
                            MovieID = 3,
                            ActorID = 5
                        },
                        new
                        {
                            MovieID = 4,
                            ActorID = 8
                        },
                        new
                        {
                            MovieID = 4,
                            ActorID = 7
                        },
                        new
                        {
                            MovieID = 5,
                            ActorID = 2
                        },
                        new
                        {
                            MovieID = 5,
                            ActorID = 4
                        },
                        new
                        {
                            MovieID = 6,
                            ActorID = 3
                        },
                        new
                        {
                            MovieID = 6,
                            ActorID = 5
                        },
                        new
                        {
                            MovieID = 7,
                            ActorID = 1
                        },
                        new
                        {
                            MovieID = 7,
                            ActorID = 2
                        },
                        new
                        {
                            MovieID = 8,
                            ActorID = 3
                        },
                        new
                        {
                            MovieID = 8,
                            ActorID = 4
                        },
                        new
                        {
                            MovieID = 9,
                            ActorID = 5
                        },
                        new
                        {
                            MovieID = 9,
                            ActorID = 6
                        },
                        new
                        {
                            MovieID = 10,
                            ActorID = 7
                        },
                        new
                        {
                            MovieID = 10,
                            ActorID = 8
                        },
                        new
                        {
                            MovieID = 11,
                            ActorID = 1
                        },
                        new
                        {
                            MovieID = 11,
                            ActorID = 8
                        },
                        new
                        {
                            MovieID = 12,
                            ActorID = 2
                        },
                        new
                        {
                            MovieID = 12,
                            ActorID = 7
                        },
                        new
                        {
                            MovieID = 13,
                            ActorID = 3
                        },
                        new
                        {
                            MovieID = 13,
                            ActorID = 6
                        },
                        new
                        {
                            MovieID = 14,
                            ActorID = 4
                        },
                        new
                        {
                            MovieID = 14,
                            ActorID = 5
                        });
                });

            modelBuilder.Entity("MovieRatingEngine.Infrastructure.Ef.Entities.MovieActor", b =>
                {
                    b.HasOne("MovieRatingEngine.Infrastructure.Ef.Entities.Actor", "Actor")
                        .WithMany("Movies")
                        .HasForeignKey("ActorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieRatingEngine.Infrastructure.Ef.Entities.Movie", "Movie")
                        .WithMany("Actors")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MovieRatingEngine.Infrastructure.Ef.Entities.Actor", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("MovieRatingEngine.Infrastructure.Ef.Entities.Movie", b =>
                {
                    b.Navigation("Actors");
                });
#pragma warning restore 612, 618
        }
    }
}
