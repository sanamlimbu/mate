using Mate.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Persistence.Configurations;

public class PostConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        // Apply common configuration
        CommonConfiguration.Configure(builder);

        builder
           .HasOne(e => e.User)
           .WithMany(e => e.Posts)
           .HasForeignKey(e => e.UserId)
           .IsRequired();

        builder
            .HasMany(e => e.Medias)
            .WithOne()
            .HasForeignKey(e => e.Id)
            .IsRequired();
    }
}

