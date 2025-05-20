using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using api.Domain.Models;

namespace api.Core.Mapping;

public class UserClassMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK____User");
        builder.ToTable("User");
        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.IsActive)
            .HasColumnName("is_active");

        builder.Property(e => e.Name)
            .HasMaxLength(550)
            .HasColumnName("name");

        builder.Property(e => e.Document)
            .HasMaxLength(75)
            .HasColumnName("document");

        builder.Property(e => e.Email)
            .HasMaxLength(255)
            .HasColumnName("email");

        builder.Property(e => e.Hash)
            .HasMaxLength(255)
            .HasColumnName("hash");

        builder.Property(e => e.Phone)
            .HasMaxLength(25)
            .HasColumnName("phone");

        builder.Property(e => e.IdAddress)
            .HasColumnName("id_address");

        builder.Property(e => e.IdRole)
            .HasColumnName("id_role");

        builder.Property(e => e.IdImage)
            .HasColumnName("id_image");

        builder.Property(e => e.IdCompany)
            .HasColumnName("id_company");

    }
}
