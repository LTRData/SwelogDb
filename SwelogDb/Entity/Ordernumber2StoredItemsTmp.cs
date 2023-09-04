using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Ordernumber2StoredItemsTmp
{
    public string OrderNumber2 { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public string? StockingUnit { get; set; }

    public decimal Qty { get; set; }

    public decimal CostPrice { get; set; }

    public decimal Amount { get; set; }

    public string UserId { get; set; } = null!;
}
