using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwFactItemCostPriceCu25
{
    public string ItemNumber { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public string? ProductGroup { get; set; }

    public string? StockingUnit { get; set; }

    public string? ItemType2 { get; set; }

    public string? ItemType3 { get; set; }

    public decimal? SumComponentCostPrice { get; set; }
}
