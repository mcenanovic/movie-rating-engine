using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRatingEngine.Infrastructure.Ef.Entities;

namespace MovieRatingEngine.Infrastructure.Ef.EntityTypeConfigurations
{
    internal class MovieActorEntityTypeConfiguration : IEntityTypeConfiguration<MovieActor>
    {
        public void Configure(EntityTypeBuilder<MovieActor> builder)
        {
            builder.ToTable("MovieActors");

            builder.HasKey(x => new { x.MovieID, x.ActorID });

            builder
                .HasOne(x => x.Movie)
                .WithMany(x => x.Actors)
                .HasForeignKey(x => x.MovieID);

            builder
                .HasOne(x => x.Actor)
                .WithMany(x => x.Movies)
                .HasForeignKey(x => x.ActorID);
        }
    }
}
