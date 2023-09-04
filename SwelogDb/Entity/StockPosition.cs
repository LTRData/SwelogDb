using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class StockPosition
{
    public string WarehouseId { get; set; } = null!;

    public string LocationId { get; set; } = null!;

    public string StockPosition1 { get; set; } = null!;

    public string? StockPositionDescription { get; set; }

    public string? AuditStamp { get; set; }

    public bool? BlockedFlag { get; set; }

    public virtual StoreLocation StoreLocation { get; set; } = null!;
}
