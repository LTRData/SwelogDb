using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemBalancesTemp
{
    public string ItemNumber { get; set; } = null!;

    public string? StockingUnit { get; set; }

    public decimal? CurrentBalance { get; set; }

    public decimal? ItemReservedQty { get; set; }

    public decimal? PurchaseOrderQuantity { get; set; }

    public decimal? ManufacturingOrderQuantity { get; set; }

    public decimal? BalanceUnderInspection { get; set; }
}
