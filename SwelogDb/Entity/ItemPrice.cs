using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemPrice
{
    public int SerialNumber { get; set; }

    public string? ItemNumber { get; set; }

    public DateTime? ValidFrom { get; set; }

    public decimal? Price { get; set; }

    public short? PriceUnitNum { get; set; }

    public string? PriceType { get; set; }

    public string? AuditStamp { get; set; }
}
