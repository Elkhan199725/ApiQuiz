using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIQuiz.Business.DTOs.BlogDto;

namespace WebAPIQuiz.Business.DTOs.BlogDtoValidation;

public class BlogCreateDtoValidator : AbstractValidator<BlogCreateDto>
{
	public BlogCreateDtoValidator()
	{
		RuleFor(x => x.Title)
			.NotEmpty()
			.WithMessage("Title is required")
			.Length(5, 500)
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
			.WithMessage("Image cannot be empty");
    }
}
