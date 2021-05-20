using FluentValidation;
using MyPro.Core.UserManagement.Entities;

namespace MyPro.Core.UserManagement.Validators
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
