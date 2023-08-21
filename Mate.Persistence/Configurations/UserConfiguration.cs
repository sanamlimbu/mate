using Mate.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        // Apply common configuration
        CommonConfiguration.Configure(builder);

        builder
           .HasIndex(e => e.FirebaseID)
           .IsUnique();
    }
}

