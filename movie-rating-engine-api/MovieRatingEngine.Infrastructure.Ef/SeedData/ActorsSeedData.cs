using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRatingEngine.Infrastructure.Ef.Entities;

namespace MovieRatingEngine.Infrastructure.Ef.SeedData
{
    internal static class ActorsSeedData
    {
        public static void SeedData(this EntityTypeBuilder<Actor> builder)
        {
            builder.HasData(
                new Actor
                {
                    ActorID = 1,
                    FirstName = "John",
                    LastName = "Doe"
                },
                new Actor
                {
                    ActorID = 2,
                    FirstName = "Edin",
                    LastName = "Dzeko"
                },
                new Actor
                {
                    ActorID = 3,
                    FirstName = "Dino",
                    LastName = "Merlin"
                }
            );
        }
    }
}
