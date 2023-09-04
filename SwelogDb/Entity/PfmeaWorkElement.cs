using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PfmeaWorkElement
{
    public string WorkElementCode { get; set; } = null!;

    public string? WorkElementDescription { get; set; }

    public string? AuditStamp { get; set; }
}
