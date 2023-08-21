using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Mate.Domain.Common;

namespace Mate.Domain.Entities;

public sealed class User : BaseEntity
{
    [Required]
    public required string FirebaseID { get; set; }
    public string? ProfileURL { get; set; }
    public string? BannerURL { get; set; }
    [JsonIgnore]
    public ICollection<Post>? Posts { get; set; }
    [JsonIgnore]
    public ICollection<Comment>? Comments { get; set; }
    [JsonIgnore]
    public ICollection<Reply>? Replies { get; set; }
}

