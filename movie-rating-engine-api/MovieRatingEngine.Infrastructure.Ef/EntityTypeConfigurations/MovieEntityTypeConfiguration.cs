using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRatingEngine.Infrastructure.Ef.Entities;
using MovieRatingEngine.Infrastructure.Ef.SeedData;

namespace MovieRatingEngine.Infrastructure.Ef.EntityTypeConfigurations
{
    internal class MovieEntityTypeConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movies");

            builder.HasKey(x => x.MovieID);

            builder
                .Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(300);

            builder
                .Property(x => x.VoteCount)
                .IsRequired()
                .HasDefaultValue(0);

            builder
                .Property(x => x.Rating)
                .IsRequired()
                .HasDefaultValue(0m)
                .HasPrecision(3,2);

            builder
                .Property(x => x.ReleaseDate)
                .IsRequired();

            builder
                .Property(x => x.IsMovie)
                .IsRequired();

            builder
                .Property(x => x.ImageName);

            builder.SeedData();
        }
    }
}
