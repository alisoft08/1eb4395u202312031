using eb4395u202312031.Observability.Domain.Model.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace eb4395u202312031.Observability.Infrastructure.Persistence.EFC.Configuration.Extensions;

/// <summary>
/// Provides Fluent API configuration for the ThingState aggregate in the Observability context.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public static class ModelBuilderExtensions
{
    /// <summary>
    /// Applies entity configuration for the ThingState aggregate, including key setup and mapping of value objects.
    /// </summary>
    /// <param name="builder">The <see cref="ModelBuilder"/> used to configure the EF Core model.</param>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public static void ApplyThingStateConfiguration(this ModelBuilder builder)
    {
        builder.Entity<ThingState>().HasKey(t => t.Id);

        builder.Entity<ThingState>()
            .Property(t => t.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder.Entity<ThingState>().OwnsOne(i => i.ThingSerialNumber, sn =>
        {
            sn.WithOwner().HasForeignKey("Id");
            sn.Property(p => p.Identifier).HasColumnName("ThingSerialNumber");
        });
    }
}