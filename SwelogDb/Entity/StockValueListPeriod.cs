using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class StockValueListPeriod
{
    public int YearNo { get; set; }

    public int PeriodNo { get; set; }

    public string ItemNumber { get; set; } = null!;

    public decimal? Quantity { get; set; }

    public decimal? CostPrice { get; set; }

    public int? PriceUnitNum { get; set; }

    public string? StockingUnit { get; set; }

    public decimal? StockValue { get; set; }

    public string ItemType1 { get; set; } = null!;

    public string ItemType2 { get; set; } = null!;

    public string ProductGroup { get; set; } = null!;

    public string? FreeCode1 { get; set; }

    public string? FreeCode2 { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? AlloyPrice { get; set; }
}
