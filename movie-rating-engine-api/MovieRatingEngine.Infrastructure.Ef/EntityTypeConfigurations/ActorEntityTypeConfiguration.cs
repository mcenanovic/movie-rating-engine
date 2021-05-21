using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRatingEngine.Infrastructure.Ef.Entities;
using MovieRatingEngine.Infrastructure.Ef.SeedData;

namespace MovieRatingEngine.Infrastructure.Ef.EntityTypeConfigurations
{
    internal class ActorEntityTypeConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.ToTable("Actors");

            builder.HasKey(x => x.ActorID);

            builder
                .Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(30);

            builder
                .Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(30);

            builder.SeedData();
        }
    }
}
