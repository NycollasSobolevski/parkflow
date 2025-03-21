using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using api.Domain.Models;

namespace api.Core.Mapping;

public class CompanyClassMap : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK____Company");
        builder.ToTable("Company");
        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.IsActive)
            .HasColumnName("is_active");

        builder.Property(e => e.Name)
            .HasColumnName("name");

        builder.Property(e => e.Cnpj)
            .HasMaxLength(14)
            .HasColumnName("cnpj");

        builder.Property(e => e.IdAddress)
            .HasColumnName("id_address");

        builder.Property(e => e.IdPlan)
            .HasColumnName("id_plan");

        builder.Property(e => e.IdSettings)
            .HasColumnName("id_settings");

    }
}
