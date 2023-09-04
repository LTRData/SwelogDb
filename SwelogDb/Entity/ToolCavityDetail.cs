using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ToolCavityDetail
{
    public string ToolNumber { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public int? Quantity { get; set; }

    public string? AuditStamp { get; set; }

    public int IdToolCavityHeader { get; set; }
}
