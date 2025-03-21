using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using api.Domain.Models;

namespace api.Core.Mapping;

public class VehicleClassMap : IEntityTypeConfiguration<Vehicle>
{
    public void Configure(EntityTypeBuilder<Vehicle> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK____Vehicle");
        builder.ToTable("Vehicle");
        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.IsActive)
            .HasColumnName("is_active");

        builder.Property(e => e.Plate)
            .HasMaxLength(10)
            .HasColumnName("plate");

        builder.Property(e => e.Brand)
            .HasMaxLength(255)
            .HasColumnName("brand");

        builder.Property(e => e.Model)
            .HasMaxLength(550)
            .HasColumnName("model");

        builder.Property(e => e.Year)
            .HasColumnName("year");

        builder.Property(e => e.Color)
            .HasMaxLength(100)
            .HasColumnName("color");

        builder.Property(e => e.IdImage)
            .HasColumnName("id_image");

        builder.Property(e => e.IdUser)
            .HasColumnName("id_user");

    }
}
