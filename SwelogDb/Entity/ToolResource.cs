using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ToolResource
{
    public string ToolNumber { get; set; } = null!;

    public string ResourceNumber { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
