using System.ComponentModel.DataAnnotations.Schema;
using Mate.Domain.Common;

namespace Mate.Domain.Entities;

public sealed class Reply : BaseEntity
{
    public string? Content { get; set; } 
    public Guid UserId { get; set; }
    public User User { get; set; }
    public Guid CommentId { get; set; }
    public Comment Comment { get; set; }
    public Guid? MediaId { get; set; }
    [ForeignKey("MediaId")]
    public Media? Media { get; set; }
}