using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using MovieRatingEngine.Core.MovieManagement.Entities;
using MovieRatingEngine.Core.MovieManagement.Validators;

namespace MovieRatingEngine.Core.Extensions.DependencyInjection
{
    public static class DependencyInjectionExtensions
    {
        public static void AddMovieRatingEngineCore(this IServiceCollection services)
        {
            services.AddTransient<IValidator<Movie>, MovieValidator>();
        }
    }
}
