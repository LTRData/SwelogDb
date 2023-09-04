using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class LsvAccessoryStructureDtl
{
    public string OrderNumber { get; set; } = null!;

    public string ParentItemNumber { get; set; } = null!;

    public string ChildItemNumber { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public string? StockingUnit { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Price { get; set; }

    public DateTime? CalculationDate { get; set; }

    public string? AuditStamp { get; set; }
}
