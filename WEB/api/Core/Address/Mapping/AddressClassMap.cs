using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using api.Domain.Models;

namespace api.Core.Mapping;

public class AddressClassMap : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK____Address");
        builder.ToTable("Address");
        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.IsActive)
            .HasColumnName("is_active");

        builder.Property(e => e.Cep)
            .HasMaxLength(12)
            .HasColumnName("cep");

        builder.Property(e => e.Country)
            .HasMaxLength(255)
            .HasColumnName("country");

        builder.Property(e => e.State)
            .HasMaxLength(255)
            .HasColumnName("state");

        builder.Property(e => e.City)
            .HasMaxLength(255)
            .HasColumnName("city");

        builder.Property(e => e.Neighborhood)
            .HasMaxLength(255)
            .HasColumnName("neighborhood");

        builder.Property(e => e.Street)
            .HasColumnName("street");

        builder.Property(e => e.Number)
            .HasColumnName("number");

    }
}
