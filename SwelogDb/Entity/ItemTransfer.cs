using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemTransfer
{
    public string StatusFlag { get; set; } = null!;

    public DateTime? WriteDate { get; set; }

    public DateTime? ReadDate { get; set; }

    public string ItemNumber { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public string? ExtraItemDescription { get; set; }

    public string? ProductGroupCode { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? SellingPrice { get; set; }

    public string? StockingUnit { get; set; }

    public string? PicturePath { get; set; }

    public string? DetailDescription { get; set; }

    public string? Hyperlink { get; set; }

    public string? FreeCode1 { get; set; }

    public string? FreeCode2 { get; set; }

    public string? FreeCode3 { get; set; }

    public int? Guarantee { get; set; }

    public bool? HotFlag { get; set; }

    public decimal? HotPrice { get; set; }

    public string? ItemVendor { get; set; }
}
