using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SellingPricePercentage
{
    public string ProductGroup { get; set; } = null!;

    public string CustomerCategory { get; set; } = null!;

    public decimal? MarginPercentage { get; set; }

    public decimal? HotMarginPercentage { get; set; }

    public string? AuditStamp { get; set; }
}
