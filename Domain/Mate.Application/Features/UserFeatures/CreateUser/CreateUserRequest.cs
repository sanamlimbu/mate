using MediatR;

namespace Mate.Application.Features.UserFeatures.CreateUser;

public sealed record CreateUserRequest(string FirebaseUserId,
	string DisplayName,
	string Email,
	bool IsEmailVerified,
	string FirebasePhotoUr): IRequest<CreateUserResponse>;


