using AutoMapper;
using Mate.Domain.Entities;

namespace Mate.Application.Features.UserFeatures.CreateUser;

public sealed class CreateUserMapper: Profile
{
	public CreateUserMapper()
	{
        CreateMap<CreateUserRequest, User>();
        CreateMap<User, CreateUserResponse>();

    }
}

