using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TempScrapItem
{
    public int SerialNumber { get; set; }

    public string? ParentPart { get; set; }

    public string? ComponentPart { get; set; }

    public string? PriceCode { get; set; }

    public decimal? FixedPricePerUnit { get; set; }
}
