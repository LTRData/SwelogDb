using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PlanningGroupConnection
{
    public string PlanningGroupId { get; set; } = null!;

    public string ProductionGroupId { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidUpto { get; set; }

    public string? AuditStamp { get; set; }
}
