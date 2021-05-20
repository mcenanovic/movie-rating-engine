using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRatingEngine.Infrastructure.Ef.Entities;

namespace MovieRatingEngine.Infrastructure.Ef.SeedData
{
    internal static class MovieActorsSeedData
    {
        public static void SeedData(this EntityTypeBuilder<MovieActor> builder)
        {
            builder.HasData(
                new MovieActor
                {
                    MovieID = 1,
                    ActorID = 1
                },
                new MovieActor
                {
                    MovieID = 1,
                    ActorID = 2
                },
                new MovieActor
                {
                    MovieID = 1,
                    ActorID = 3
                },
                new MovieActor
                {
                    MovieID = 2,
                    ActorID = 1
                }
            );
        }
    }
}
