using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using api.Domain.Models;

namespace api.Core.Mapping;

public class PlanClassMap : IEntityTypeConfiguration<Plan>
{
    public void Configure(EntityTypeBuilder<Plan> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK____Plan");
        builder.ToTable("Plan");
        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.IsActive)
            .HasColumnName("is_active");

        builder.Property(e => e.Plan)
            .HasColumnName("plan");

        builder.Property(e => e.Title)
            .HasMaxLength(255)
            .HasColumnName("title");

        builder.Property(e => e.Description)
            .HasColumnName("description");

        builder.Property(e => e.Price)
            .HasColumnName("price");

    }
}
