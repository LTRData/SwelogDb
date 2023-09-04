using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ToolType
{
    public string ToolType1 { get; set; } = null!;

    public string? ToolTypeDescription { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ToolHeader> ToolHeaders { get; } = new List<ToolHeader>();
}
