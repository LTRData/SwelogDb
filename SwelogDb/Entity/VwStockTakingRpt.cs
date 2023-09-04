using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwStockTakingRpt
{
    public int StockTakingNo { get; set; }

    public string ItemNumber { get; set; } = null!;

    public string PalletNo { get; set; } = null!;

    public string? WarehouseId { get; set; }

    public string? StoreLocation { get; set; }

    public string? StockPosition { get; set; }

    public decimal? ListDateBalance { get; set; }

    public decimal? ReportedQuantity { get; set; }

    public DateTime? ReportedDatetime { get; set; }

    public decimal? ReportDateBalance { get; set; }

    public decimal? DifferenceValue { get; set; }

    public string? ApprovedFlag { get; set; }

    public string? ItemDescription { get; set; }

    public string? PalletFlag { get; set; }

    public string? StockingUnit { get; set; }

    public DateTime? ListCreateDatetime { get; set; }

    public string? RptSortlabel { get; set; }

    public string? RptGrouplabel { get; set; }

    public string? ManualEntryFlag { get; set; }

    public string? RptSortstring { get; set; }

    public string? RptGroupstring { get; set; }

    public string? UnitFormat { get; set; }
}
