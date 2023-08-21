using Mate.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Persistence.Configurations;

public class ReplyConfiguration : IEntityTypeConfiguration<Reply>
{
    public void Configure(EntityTypeBuilder<Reply> builder)
    {
        // Apply common configuration
        CommonConfiguration.Configure(builder);

        builder
            .HasOne(e => e.Comment)
            .WithMany(e => e.Replies)
            .HasForeignKey(r => r.CommentId);
    }
}

