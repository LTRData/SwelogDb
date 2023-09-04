using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemCostPriceHistory
{
    public string ItemNumber { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public decimal? CostPrice { get; set; }

    public short? PriceUnitNum { get; set; }

    public string? AuditStamp { get; set; }

    public int IdItemCostPriceHistory { get; set; }
}
