using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgOperationTool
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public short OperationNumber { get; set; }

    public string ToolNumber { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public short? ToolSerialNumber { get; set; }
}
