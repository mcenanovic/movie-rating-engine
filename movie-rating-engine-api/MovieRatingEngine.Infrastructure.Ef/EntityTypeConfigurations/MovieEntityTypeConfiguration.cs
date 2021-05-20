using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyPro.Infrastructure.Ef.Entities;
using MyPro.Infrastructure.Ef.SeedData;

namespace MyPro.Infrastructure.Ef.EntityTypeConfigurations
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
                .Property(x => x.ImageURL);

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
                .HasDefaultValue(0m);

            builder
                .Property(x => x.ReleaseDate)
                .IsRequired();

            builder.SeedData();
        }
    }
}
