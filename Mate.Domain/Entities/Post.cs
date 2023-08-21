using Mate.Domain.Common;

namespace Mate.Domain.Entities;

public sealed class Post : BaseEntity
{
    public string? Content { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
    public IEnumerable<Comment>? Comments { get; set; }
    public IEnumerable<Media>? Medias { get; set; }
}

