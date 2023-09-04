using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EcoestmtVolvoPurchaseCompList
{
    public string TopItemNumber { get; set; } = null!;

    public int TopItemLot { get; set; }

    public int IdVolvoPurchaseCompLine { get; set; }

    public string? ComponentType1 { get; set; }

    public string? ComponentType2 { get; set; }

    public string? ComponentNumber { get; set; }

    public string? ComponentDescription { get; set; }

    public int? CompLevel { get; set; }

    public int? Lotsize { get; set; }

    public decimal? CurrentScrapPrice { get; set; }

    public decimal? CostpriceBaseprice { get; set; }

    public decimal? Qty { get; set; }

    public decimal? PurchasePrice { get; set; }

    public decimal? PurchaseFreight { get; set; }

    public decimal? PurchaseFixedOrderCost { get; set; }

    public decimal? TotalCost { get; set; }

    public string? Unit { get; set; }

    public string? ParentItem { get; set; }

    public string? ItemPath { get; set; }

    public string? SortOrder { get; set; }

    public decimal? Overhead { get; set; }

    public string? UnitFormat { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? ParentQty { get; set; }

    public decimal? IngQty { get; set; }

    public decimal? ItemPurchaseFreight { get; set; }

    public int? ComponentCosttype { get; set; }

    public int? LastOperation { get; set; }

    public string? CostPriceExchangeDescr { get; set; }

    public string? DoNotCalculateOverheadProfitYn { get; set; }

    public decimal? AlloyPrice { get; set; }
}
