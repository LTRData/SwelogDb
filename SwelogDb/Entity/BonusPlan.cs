using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BonusPlan
{
    public string CostCentre { get; set; } = null!;

    public decimal Efficiency { get; set; }

    public decimal? GroupAmount { get; set; }

    public decimal? AllPercent { get; set; }

    public string? AuditStamp { get; set; }
}
