using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemAccumulatorBalance
{
    public int YearNo { get; set; }

    public int MonthNo { get; set; }

    public string ItemNumber { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public string? StockingUnit { get; set; }

    public decimal? CostPrice { get; set; }

    public int? PriceUnitNum { get; set; }

    public decimal? ClosingBalance { get; set; }

    public decimal? IssueQuantity { get; set; }

    public decimal? ReceiptQuantity { get; set; }

    public string? QtyFormat { get; set; }

    public decimal? ResourceLocBalance { get; set; }
}
