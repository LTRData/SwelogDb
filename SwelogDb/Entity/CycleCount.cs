using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CycleCount
{
    public string CycleCountCode { get; set; } = null!;

    public string? CycleCountDescription { get; set; }

    public int? StockTakeIntervalDays { get; set; }

    public int? CheckIntervalDays { get; set; }

    public string? AuditStamp { get; set; }
}
