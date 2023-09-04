using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class StockValueList
{
    public string ItemNumber { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public string? ProductGroup { get; set; }

    public string? StockingUnit { get; set; }

    public string? ItemType1 { get; set; }

    public string? ItemType2 { get; set; }

    public string StockLocation { get; set; } = null!;

    public short? PriceUnitNum { get; set; }

    public decimal? CostPrice { get; set; }

    public string? AbcCode { get; set; }

    public decimal? Balance { get; set; }

    public decimal? StockValue { get; set; }

    public DateTime? ValueDate { get; set; }

    public DateTime? LastReceiptDate { get; set; }

    public decimal? TmpNum { get; set; }

    public string? ItemStatus1 { get; set; }

    public DateTime? LastTransDateBeforeValueDate { get; set; }

    public string? FreeCode1 { get; set; }

    public string? FreeCode2 { get; set; }

    public string? FreeCode3 { get; set; }

    public DateTime? StockTakeReferenceDate { get; set; }

    public decimal? StockTakeReferenceBalance { get; set; }

    public string? StockTakeReferenceCase { get; set; }

    public DateTime? CostPriceDate { get; set; }

    public string StorePosition { get; set; } = null!;

    public int SerialNumber { get; set; }

    public DateTime? StockTakeReference { get; set; }

    public DateTime? LastWithdrawDate { get; set; }

    public short? LastWithdrawMonthAgo { get; set; }

    public string? ObsoleteYn { get; set; }
}
