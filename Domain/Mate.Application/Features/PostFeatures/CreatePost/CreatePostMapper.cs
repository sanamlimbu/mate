using AutoMapper;
using Mate.Domain.Entities;

namespace Mate.Application.Features.PostFeatures.CreatePost;

public sealed class CreatePostMapper: Profile
{
	public CreatePostMapper()
	{
		CreateMap<CreatePostRequest, Post>();
		CreateMap<Post, CreatePostResponse>();
	}
}

