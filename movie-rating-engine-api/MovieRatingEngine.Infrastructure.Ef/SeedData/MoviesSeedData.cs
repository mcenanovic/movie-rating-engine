using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyPro.Infrastructure.Ef.Entities;
using System;

namespace MyPro.Infrastructure.Ef.SeedData
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
                    ReleaseDate = DateTime.Now.Date
                },
                new Movie
                {
                    MovieID = 2,
                    Title = "Movie 2",
                    Description = "Description of movie 2",
                    VoteCount = 1,
                    Rating = 4m,
                    ReleaseDate = DateTime.Now.Date
                }
            );
        }
    }
}
