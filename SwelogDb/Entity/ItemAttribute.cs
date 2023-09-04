using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemAttribute
{
    public string ItemNumber { get; set; } = null!;

    public string? ModelCode { get; set; }

    public string? GoodsCode { get; set; }

    public string? FabricCode { get; set; }

    public string? ColourCode { get; set; }

    public string? AuditStamp { get; set; }

    public string? PalletCode { get; set; }

    public string? PackageFlag { get; set; }

    public string? NoPalletCalculation { get; set; }

    public string? SortOnGoodsMarkYn { get; set; }
}
