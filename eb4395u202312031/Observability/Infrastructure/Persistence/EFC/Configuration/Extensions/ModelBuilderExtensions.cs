using eb4395u202312031.Observability.Domain.Model.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace eb4395u202312031.Observability.Infrastructure.Persistence.EFC.Configuration.Extensions;

public static class ModelBuilderExtensions
{
    public static void ApplyThingStateConfiguration(this ModelBuilder builder)
    {
        builder.Entity<ThingState>().HasKey(t => t.Id);

        builder.Entity<ThingState>()
            .Property(t => t.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();
        
        //este si compila, pero no se puede usar el value object como clave foránea
        // builder.Entity<ThingState>().OwnsOne(
        //     t => t.ThingSerialNumber,
        //     sn =>
        //     {
        //         sn.WithOwner().HasForeignKey("Id"); // Usa la columna 'Id' como clave foránea
        //         sn.Property(p => p.Identifier).HasColumnName("ThingSerialNumber"); // Nombra la columna del value object
        //     });
        
        //
        //nunca funcionó
        // builder.Entity<ThingState>().OwnsOne(
        //     t => t.ThingSerialNumber,
        //     sn =>
        //     {
        //         sn.Property(p => p.Identifier)
        //             .HasColumnName("ThingSerialNumber")
        //             .IsRequired();
        //         // Eliminado sn.WithOwner() y sn.HasKey()
        //     });
        
        builder.Entity<ThingState>().OwnsOne(i => i.ThingSerialNumber, sn =>
        {
            sn.WithOwner().HasForeignKey("Id");
            sn.Property(p => p.Identifier).HasColumnName("ThingSerialNumber");
        });
        
    }

}