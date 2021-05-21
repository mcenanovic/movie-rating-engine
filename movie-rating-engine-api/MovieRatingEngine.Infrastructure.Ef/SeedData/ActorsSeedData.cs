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
                },
                new Actor
                {
                    ActorID = 4,
                    FirstName = "Denzel",
                    LastName = "Washington"
                },
                new Actor
                {
                    ActorID = 5,
                    FirstName = "Jason",
                    LastName = "Statham"
                },
                new Actor
                {
                    ActorID = 6,
                    FirstName = "Tom",
                    LastName = "Cruz"
                },
                new Actor
                {
                    ActorID = 7,
                    FirstName = "David",
                    LastName = "Suchet"
                },
                new Actor
                {
                    ActorID = 8,
                    FirstName = "Tom",
                    LastName = "Hanks"
                }
            );
        }
    }
}
