using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemSellingPriceHistory
{
    public string ItemNumber { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public decimal? SellingPrice { get; set; }

    public short? PriceUnitNum { get; set; }

    public string? AuditStamp { get; set; }

    public int IdItemSellingPriceHistory { get; set; }
}
