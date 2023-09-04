using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpScaniaFileResult
{
    public int RecId { get; set; }

    public string? FileData { get; set; }

    public string? ItemNumber { get; set; }

    public string? SupplierItemNumber { get; set; }

    public decimal? SellingPrice { get; set; }

    public decimal? NewSellingPrice { get; set; }

    public decimal? OrderLotQuantity { get; set; }

    public decimal? NewOrderLotQuantity { get; set; }

    public bool? LineWithHigherPrice { get; set; }

    public bool? LineWithLowerPrice { get; set; }

    public string? UomFormat { get; set; }
}
