using FluentValidation;

namespace Mate.Application.Features.UserFeatures.CreateUser;

public sealed class CreateUserValidator: AbstractValidator<CreateUserRequest>
{
	public CreateUserValidator()
	{
		RuleFor(x => x.FirebaseUserId).NotEmpty();
		RuleFor(x => x.Email).NotEmpty().EmailAddress();
	}
}

