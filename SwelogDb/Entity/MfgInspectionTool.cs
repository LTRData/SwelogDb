using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgInspectionTool
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public short OperationNumber { get; set; }

    public string InspectionToolNumber { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
