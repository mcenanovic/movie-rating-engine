using FluentValidation;
using MovieRatingEngine.Core.MovieManagement.Entities;

namespace MovieRatingEngine.Core.MovieManagement.Validators
{
    public class MovieValidator: AbstractValidator<Movie>
    {
        public MovieValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title is required");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
        }
    }
}
