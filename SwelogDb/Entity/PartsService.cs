using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PartsService
{
    public string OrderNumber { get; set; } = null!;

    public int LineNumber { get; set; }

    public string? ItemNumber { get; set; }

    public string? ItemDescription { get; set; }

    public decimal? Quantity { get; set; }

    public string? StockingUnit { get; set; }

    public DateTime? DesiredDeliveryDate { get; set; }

    public string? SupplierId { get; set; }

    public string? AuditStamp { get; set; }
}
