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
                },
                new MovieActor
                {
                    MovieID = 3,
                    ActorID = 3
                },
                new MovieActor
                {
                    MovieID = 3,
                    ActorID = 5
                },
                new MovieActor
                {
                    MovieID = 4,
                    ActorID = 8
                },
                new MovieActor
                {
                    MovieID = 4,
                    ActorID = 7
                },
                new MovieActor
                {
                    MovieID = 5,
                    ActorID = 2
                },
                new MovieActor
                {
                    MovieID = 5,
                    ActorID = 4
                },
                new MovieActor
                {
                    MovieID = 6,
                    ActorID = 3
                },
                new MovieActor
                {
                    MovieID = 6,
                    ActorID = 5
                },
                new MovieActor
                {
                    MovieID = 7,
                    ActorID = 1
                },
                new MovieActor
                {
                    MovieID = 7,
                    ActorID = 2
                },
                new MovieActor
                {
                    MovieID = 8,
                    ActorID = 3
                },
                new MovieActor
                {
                    MovieID = 8,
                    ActorID = 4
                },
                new MovieActor
                {
                    MovieID = 9,
                    ActorID = 5
                },
                new MovieActor
                {
                    MovieID = 9,
                    ActorID = 6
                },
                new MovieActor
                {
                    MovieID = 10,
                    ActorID = 7
                },
                new MovieActor
                {
                    MovieID = 10,
                    ActorID = 8
                },
                new MovieActor
                {
                    MovieID = 11,
                    ActorID = 1
                },
                new MovieActor
                {
                    MovieID = 11,
                    ActorID = 8
                },
                new MovieActor
                {
                    MovieID = 12,
                    ActorID = 2
                },
                new MovieActor
                {
                    MovieID = 12,
                    ActorID = 7
                },
                new MovieActor
                {
                    MovieID = 13,
                    ActorID = 3
                },
                new MovieActor
                {
                    MovieID = 13,
                    ActorID = 6
                },
                new MovieActor
                {
                    MovieID = 14,
                    ActorID = 4
                },
                new MovieActor
                {
                    MovieID = 14,
                    ActorID = 5
                }
            );
        }
    }
}
