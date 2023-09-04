using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ToolCavityHeader
{
    public string ToolNumber { get; set; } = null!;

    public short? NumberOfPresses { get; set; }

    public string? AuditStamp { get; set; }

    public string? Alternative { get; set; }

    public int IdToolCavityHeader { get; set; }
}
