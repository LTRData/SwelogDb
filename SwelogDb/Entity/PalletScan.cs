using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PalletScan
{
    public int IdPalletScan { get; set; }

    public string? PalletNo { get; set; }

    public string? PalletType { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public int? OperationNumber { get; set; }

    public decimal? Quantity { get; set; }

    public string? Status { get; set; }

    public string? StoreLocationFrom { get; set; }

    public string? StoreLocationTo { get; set; }

    public string? StockPositionFrom { get; set; }

    public string? StockPositionTo { get; set; }

    public DateTime? ScanDate { get; set; }

    public string? ScanBy { get; set; }
}
