using Microsoft.EntityFrameworkCore;

namespace eb4395u202312031.Inventory.Infrastructure.Persistence.EFC.Configuration.Extensions;

/// <summary>
/// Provides extension methods to apply entity configurations for the Thing aggregate using the Fluent API.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public static class ModelBuilderExtensions
{
    /// <summary>
    /// Applies the configuration for the Thing entity, including its key, identity generation, and value object mapping.
    /// </summary>
    /// <param name="builder">The <see cref="ModelBuilder"/> instance used to configure the EF Core model.</param>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public static void ApplyThingConfiguration(this ModelBuilder builder)
    {
        builder.Entity<Thing>().HasKey(t => t.Id);

        builder.Entity<Thing>()
            .Property(t => t.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder.Entity<Thing>().OwnsOne(i => i.SerialNumber, sn =>
        {
            sn.WithOwner().HasForeignKey("Id");
            sn.Property(p => p.Identifier).HasColumnName("SerialNumber");
        });
    }
}