using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRatingEngine.Infrastructure.Ef.Entities;
using System;

namespace MovieRatingEngine.Infrastructure.Ef.SeedData
{
   internal static class MoviesSeedData
    {
        public static void SeedData(this EntityTypeBuilder<Movie> builder)
        {
            builder.HasData(
                new Movie
                {
                    MovieID = 1,
                    Title = "Movie 1",
                    Description = "Description of movie 1",
                    VoteCount = 1,
                    Rating = 3m,
                    ReleaseDate = DateTime.Now.Date,
                    IsMovie = true,
                    ImageName = "1.png"
                },
                new Movie
                {
                    MovieID = 2,
                    Title = "Movie 2",
                    Description = "Description of movie 2",
                    VoteCount = 1,
                    Rating = 4m,
                    ReleaseDate = DateTime.Now.Date,
                    IsMovie = true,
                    ImageName = "2.png"
                },
                new Movie
                {
                    MovieID = 3,
                    Title = "Movie 3",
                    Description = "Description of movie 3",
                    VoteCount = 3,
                    Rating = 3.5m,
                    ReleaseDate = DateTime.Now.Date,
                    IsMovie = true
                },
                new Movie
                {
                    MovieID = 4,
                    Title = "Movie 4",
                    Description = "Description of movie 4",
                    VoteCount = 2,
                    Rating = 4.5m,
                    ReleaseDate = DateTime.Now.Date,
                    IsMovie = true,
                    ImageName = "4.png"
                },
                new Movie
                {
                    MovieID = 5,
                    Title = "TV Show 5",
                    Description = "Description of TV Show 5",
                    VoteCount = 5,
                    Rating = 2.4m,
                    ReleaseDate = new DateTime(2005, 1, 20),
                    IsMovie = false,
                    ImageName = "5.png"
                },
                new Movie
                {
                    MovieID = 6,
                    Title = "TV Show 6",
                    Description = "Description of TV Show 6",
                    VoteCount = 2,
                    Rating = 3.4m,
                    ReleaseDate = new DateTime(2012, 6, 5),
                    IsMovie = false,
                    ImageName = "6.png"
                },
                new Movie
                {
                    MovieID = 7,
                    Title = "Movie 7",
                    Description = "Description of movie 7",
                    VoteCount = 5,
                    Rating = 4.4m,
                    ReleaseDate = new DateTime(2015, 2, 25),
                    IsMovie = true,
                    ImageName = "7.png"
                },
                new Movie
                {
                    MovieID = 8,
                    Title = "Movie 8",
                    Description = "Description of movie 8",
                    VoteCount = 5,
                    Rating = 2.4m,
                    ReleaseDate = new DateTime(2000, 5, 20),
                    IsMovie = true,
                    ImageName = "8.png"
                },
                new Movie
                {
                    MovieID = 9,
                    Title = "Movie 9",
                    Description = "Description of movie 9",
                    VoteCount = 3,
                    Rating = 4.1m,
                    ReleaseDate = new DateTime(2007, 7, 19),
                    IsMovie = true,
                    ImageName = "9.png"
                },
                new Movie
                {
                    MovieID = 10,
                    Title = "Movie 10",
                    Description = "Description of movie 10",
                    VoteCount = 1,
                    Rating = 3.0m,
                    ReleaseDate = new DateTime(2019, 4, 13),
                    IsMovie = true,
                    ImageName = "10.png"
                },
                new Movie
                {
                    MovieID = 11,
                    Title = "Movie 11",
                    Description = "Description of movie 11",
                    VoteCount = 2,
                    Rating = 3.5m,
                    ReleaseDate = new DateTime(2017, 7, 13),
                    IsMovie = true,
                    ImageName = "11.png"
                },
                new Movie
                {
                    MovieID = 12,
                    Title = "Movie 12",
                    Description = "Description of movie 12",
                    VoteCount = 3,
                    Rating = 2.7m,
                    ReleaseDate = new DateTime(2014, 2, 2),
                    IsMovie = true,
                    ImageName = "12.png"
                },
                new Movie
                {
                    MovieID = 13,
                    Title = "Movie 13",
                    Description = "Description of movie 13",
                    VoteCount = 3,
                    Rating = 4.7m,
                    ReleaseDate = new DateTime(2012, 1, 1),
                    IsMovie = true,
                    ImageName = "13.png"
                },
                new Movie
                {
                    MovieID = 14,
                    Title = "Movie 14",
                    Description = "Description of movie 14",
                    VoteCount = 4,
                    Rating = 5.0m,
                    ReleaseDate = new DateTime(2016, 8, 15),
                    IsMovie = true,
                    ImageName = "14.png"
                }
            );
        }
    }
}
