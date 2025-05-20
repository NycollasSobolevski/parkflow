using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using api.Domain.Models;

namespace api.Core.Mapping;

public class CompanySettingsClassMap : IEntityTypeConfiguration<CompanySettings>
{
    public void Configure(EntityTypeBuilder<CompanySettings> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK____CompanySettings");
        builder.ToTable("CompanySettings");
        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.IsActive)
            .HasColumnName("is_active");

        builder.Property(e => e.VehiclePerUser)
            .HasColumnName("vehicle_per_user");

    }
}
