using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TrTerminalView
{
    public string ViewCode { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidUntil { get; set; }

    public string? ViewDescription { get; set; }

    public string? AuditStamp { get; set; }
}
