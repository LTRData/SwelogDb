using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgExecution
{
    public int MfgOrderSerialKey { get; set; }

    public DateTime? ActualStartDate { get; set; }

    public DateTime? ActualFinishDate { get; set; }

    public short? Priority { get; set; }

    public string? MaterialCheck { get; set; }

    public string? ToolCheck { get; set; }

    public string? CapacityCheck { get; set; }

    public string? ExecutionStatus { get; set; }

    public string? AuditStamp { get; set; }

    public string? PriorOpnCheck { get; set; }

    public string? PlannedResourceNo { get; set; }
}
