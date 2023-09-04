using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DivisionActivityPlanning
{
    public string ActivityNo { get; set; } = null!;

    public int MfgOrderSerialKey { get; set; }

    public int PlannedQuantity { get; set; }

    public string? AuditStamp { get; set; }
}
