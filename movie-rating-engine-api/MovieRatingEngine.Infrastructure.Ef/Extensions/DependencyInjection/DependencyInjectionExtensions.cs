using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieRatingEngine.Infrastructure.Ef;
using MyPro.Core.UserManagement.Repositories;
using MyPro.Infrastructure.Ef.Repositories.UserManagement;

namespace MyPro.Infrastructure.Ef.Extensions.DependencyInjection
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
