using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PurchaseOverheadPercentage
{
    public string PercentageCode { get; set; } = null!;

    public decimal? Percentage { get; set; }

    public string? AuditStamp { get; set; }
}
