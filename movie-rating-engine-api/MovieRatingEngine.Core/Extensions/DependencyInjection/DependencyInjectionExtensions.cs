using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using MyPro.Core.UserManagement.Entities;
using MyPro.Core.UserManagement.Validators;

namespace MyPro.Core.Extensions.DependencyInjection
{
    public static class DependencyInjectionExtensions
    {
        public static void AddMovieRatingEngineCore(this IServiceCollection services)
        {
            services.AddTransient<IValidator<Movie>, MovieValidator>();
        }
    }
}
