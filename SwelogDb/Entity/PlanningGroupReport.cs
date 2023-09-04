using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PlanningGroupReport
{
    public string PlanningGroupId { get; set; } = null!;

    public DateTime StartDateTime { get; set; }

    public string ResourceNo { get; set; } = null!;

    public short? PercentShare { get; set; }

    public string? FixedOption { get; set; }

    public string? AuditStamp { get; set; }

    public DateTime? ValidUpto { get; set; }
}
