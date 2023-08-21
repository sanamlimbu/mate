using FluentValidation;

namespace Mate.Application.Features.PostFeatures.CreatePost;

public sealed class CreatePostValidaton: AbstractValidator<CreatePostRequest>
    {
	public CreatePostValidaton()
	{

    }
}

