using Microsoft.EntityFrameworkCore;
using MovieRatingEngine.Infrastructure.Ef.Entities;
using MovieRatingEngine.Infrastructure.Ef.EntityTypeConfigurations;
using MyPro.Infrastructure.Ef.Entities;
using MyPro.Infrastructure.Ef.EntityTypeConfigurations;

namespace MovieRatingEngine.Infrastructure.Ef
{
    internal class MovieRatingEngineDbContext : DbContext
    {
        public MovieRatingEngineDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new MovieEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ActorEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MovieActorEntityTypeConfiguration());
        }
    }
}
