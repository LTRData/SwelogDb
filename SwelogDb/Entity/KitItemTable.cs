using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class KitItemTable
{
    public string KitId { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public decimal? Quantity { get; set; }

    public string? UnitOfQuantity { get; set; }

    public string? AuditStamp { get; set; }

    public virtual Item ItemNumberNavigation { get; set; } = null!;

    public virtual KitOrder Kit { get; set; } = null!;

    public virtual UnitOfMeasure? UnitOfQuantityNavigation { get; set; }
}
