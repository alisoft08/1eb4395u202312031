using System;
using System.ComponentModel.DataAnnotations.Schema;
using EntityFrameworkCore.CreatedUpdatedDate.Contracts;

namespace eb4395u202312031.Inventory.Domain.Model.Aggregates;

/// <summary>
/// Adds audit trail properties to the Thing aggregate to track creation and update timestamps.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public partial class Thing : IEntityWithCreatedUpdatedDate
{
    /// <summary>
    /// Gets or sets the date and time when the entity was created.
    /// </summary>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    [Column("CreatedAt")]
    public DateTimeOffset? CreatedDate { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the entity was last updated.
    /// </summary>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    [Column("UpdatedAt")]
    public DateTimeOffset? UpdatedDate { get; set; }
}