namespace Mate.Application.Features.PostFeatures.CreatePost;

public sealed record CreatePostResponse
{
    public Guid Id { get; set; }
    public string Content { get; set; }
}

