using Mate.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Persistence.Configurations;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        // Apply common configuration
        CommonConfiguration.Configure(builder);

        builder
          .HasOne(e => e.User)
          .WithMany(e => e.Comments)
          .HasForeignKey(e => e.UserId)
          .IsRequired();

        builder
            .HasOne(e => e.Post)
            .WithMany(e => e.Comments)
            .HasForeignKey(e => e.PostId)
            .IsRequired();
        builder
            .HasOne(e => e.Media);
    }
}

