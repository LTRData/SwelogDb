using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PurchStatTargetPerItem
{
    public string ItemNumber { get; set; } = null!;

    public int PeriodId { get; set; }

    public decimal? Target { get; set; }

    public decimal? OpeningPrice { get; set; }

    public string? AuditStamp { get; set; }

    public virtual PurchStatPeriod Period { get; set; } = null!;
}
