using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieRatingEngine.Core.MovieManagement.Repositories;
using MovieRatingEngine.Infrastructure.Ef.Repositories.MovieManagement;

namespace MovieRatingEngine.Infrastructure.Ef.Extensions.DependencyInjection
{
    public static class DependencyInjectionExtensions
    {
        public static void AddMovieRatingEngineInfrastructureEf(this IServiceCollection services, string sqlConnectionString)
        {
            services.AddDbContext<MovieRatingEngineDbContext>(opt =>
            {
                opt.UseSqlServer(sqlConnectionString);
            });

            services.AddTransient<IMovieRepository, MovieRepository>();
        }
    }
}
