using MediatR;


namespace Mate.Application.Features.PostFeatures.CreatePost;

public sealed record CreatePostRequest(string content) : IRequest<CreatePostResponse>;

