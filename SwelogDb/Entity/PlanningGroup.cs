using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PlanningGroup
{
    public string PlanningGroupId { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidUpto { get; set; }

    public string? GroupDescription { get; set; }

    public string? CostCentre { get; set; }

    public string? CostCentreDescription { get; set; }

    public string? AuditStamp { get; set; }
}
