using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PurchStatTargetPerProdGroup
{
    public string ProductGroup { get; set; } = null!;

    public int PeriodId { get; set; }

    public decimal? Target { get; set; }

    public string? AuditStamp { get; set; }

    public virtual PurchStatPeriod Period { get; set; } = null!;
}
