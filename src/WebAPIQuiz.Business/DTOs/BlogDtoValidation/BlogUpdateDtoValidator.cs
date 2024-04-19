using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIQuiz.Business.DTOs.BlogDto;

namespace WebAPIQuiz.Business.DTOs.BlogDtoValidation;

public class BlogUpdateDtoValidator : AbstractValidator<BlogUpdateDto>
{
    public BlogUpdateDtoValidator()
    {
        RuleFor(x => x.Id)
            .NotNull()
            .GreaterThanOrEqualTo(1)
            .WithMessage("Valid ID is required");

        RuleFor(x => x.Title)
            .NotEmpty()
            .WithMessage("Title is required")
            .Length(5, 500)
            .When(x => x.Title != null)
            .WithMessage("Title must be between 5 and 500");

        		RuleFor(x => x.Description)
			.NotEmpty()
            .WithMessage("Description is required")
            .Length(20,1000)
            .WithMessage("Description must be between 20 and 1000");

        		RuleFor(x => x.ImageUrl)
			.NotNull()
			.WithMessage("Image is required")
			.Must(image => image.Length > 0)
            .When(x => x.ImageUrl != null)
            .WithMessage("Image cannot be empty");

    }
}
