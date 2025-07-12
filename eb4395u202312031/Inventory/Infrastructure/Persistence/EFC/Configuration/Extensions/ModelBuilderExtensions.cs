using eb4395u202312031.Inventory.Domain.Model.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace eb4395u202312031.Inventory.Infrastructure.Persistence.EFC.Configuration.Extensions;

public static class ModelBuilderExtensions
{
    public static void ApplyThingConfiguration(this ModelBuilder builder)
    {
        builder.Entity<Thing>().HasKey(t => t.Id);
        builder.Entity<Thing>().Property(t => t.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Thing>().OwnsOne(i => i.SerialNumber, sn =>
        {
            sn.WithOwner().HasForeignKey("Id");
            sn.Property(p => p.Identifier).HasColumnName("SerialNumber");
        });
    }
}