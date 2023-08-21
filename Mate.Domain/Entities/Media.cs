using System.ComponentModel.DataAnnotations;
using Mate.Domain.Common;

namespace Mate.Domain.Entities;

public sealed class Media : BaseEntity
{
    [Required]
    public string MimeType { get; set; }
    [Required]
    public long FileSizeBytes { get; set; }
    [Required]
    public string Extension { get; set; }
    [Required]
    public string Url { get; set; }
}

