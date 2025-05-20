using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using api.Domain.Models;

namespace api.Core.Mapping;

public class GoogleAuthenticationClassMap : IEntityTypeConfiguration<GoogleAuthentication>
{
    public void Configure(EntityTypeBuilder<GoogleAuthentication> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK____GoogleAuthentication");
        builder.ToTable("GoogleAuthentication");
        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.IsActive)
            .HasColumnName("is_active");

        builder.Property(e => e.Token)
            .HasMaxLength(500)
            .HasColumnName("token");

        builder.Property(e => e.IdUser)
            .HasColumnName("id_user");

    }
}
