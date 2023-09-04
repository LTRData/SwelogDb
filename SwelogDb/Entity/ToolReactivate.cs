using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ToolReactivate
{
    public string ToolNumber { get; set; } = null!;

    public short ToolSerialNumber { get; set; }

    public string ToolReactivateType { get; set; } = null!;

    public string? ToolReactivateText { get; set; }

    public decimal? ToolReactivateCost { get; set; }

    public DateTime ToolReactivateDate { get; set; }

    public string? AuditStamp { get; set; }

    public int ReactivateIndex { get; set; }

    public virtual ToolDetail Tool { get; set; } = null!;
}
