using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Mate.Domain.Common;

namespace Mate.Domain.Entities;

public sealed class Comment : BaseEntity
{
    public string? Content { get; set; } 
    public Guid UserId { get; set; }
    public User User { get; set; }
    public Guid PostId { get; set; }
    [JsonIgnore]
    public Post Post { get; set; }
    public ICollection<Reply> Replies { get; set; }
    public Guid? MediaId { get; set; }
    [ForeignKey("MediaId")]
    public Media? Media { get; set; }
}