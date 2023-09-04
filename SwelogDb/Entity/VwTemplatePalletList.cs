using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwTemplatePalletList
{
    public string? PalletNo { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public int? OperationNumber { get; set; }

    public string? ItemDescription { get; set; }

    public string? OperationDesc { get; set; }

    public string? StoreLocation { get; set; }

    public string? StockPosition { get; set; }

    public decimal? Quantity { get; set; }

    public string? LocationType { get; set; }

    public decimal? QtyProduced { get; set; }

    public decimal? QtyConsumed { get; set; }

    public string? PalletType { get; set; }

    public int? QtyAdjusted { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public int? ParentLotNumber { get; set; }

    public int? ParentOperationNumber { get; set; }

    public int? Color { get; set; }

    public int? Locked { get; set; }

    public int? ReworkLotNumber { get; set; }

    public decimal? CostPrice { get; set; }

    public string? CategoryCode { get; set; }

    public string? CategoryDesc { get; set; }

    public string? PalletStatus { get; set; }

    public string? QuantityFormat { get; set; }

    public string? StockingUnit { get; set; }

    public decimal? AlloyPrice { get; set; }

    public string? ControlId { get; set; }

    public decimal? TotaccumComponentCost { get; set; }

    public decimal? TotaccumWagecost { get; set; }

    public decimal? TotaccumOther { get; set; }

    public decimal? ContributionMargin1 { get; set; }

    public string? NewStoreLocation { get; set; }

    public string? NewStockPosition { get; set; }

    public string? AdjustBalance { get; set; }

    public decimal? ActualBalance { get; set; }

    public string? BlockPallet { get; set; }

    public string? RefTranNo { get; set; }

    public DateTime? RefDate { get; set; }
}
