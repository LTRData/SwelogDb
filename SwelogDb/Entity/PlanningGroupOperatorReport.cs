using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PlanningGroupOperatorReport
{
    public int EmployeeNumber { get; set; }

    public DateTime StartDateTime { get; set; }

    public string PlanningGroupId { get; set; } = null!;

    public DateTime? ValidUpto { get; set; }

    public string? AuditStamp { get; set; }
}
