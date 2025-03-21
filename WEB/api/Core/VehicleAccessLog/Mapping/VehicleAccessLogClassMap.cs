using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using api.Domain.Models;

namespace api.Core.Mapping;

public class VehicleAccessLogClassMap : IEntityTypeConfiguration<VehicleAccessLog>
{
    public void Configure(EntityTypeBuilder<VehicleAccessLog> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK____VehicleAccessLog");
        builder.ToTable("VehicleAccessLog");
        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.IsActive)
            .HasColumnName("is_active");

        builder.Property(e => e.In)
            .HasColumnName("in");

        builder.Property(e => e.Out)
            .HasColumnName("out");

        builder.Property(e => e.IdVehicle)
            .HasColumnName("id_vehicle");

    }
}
