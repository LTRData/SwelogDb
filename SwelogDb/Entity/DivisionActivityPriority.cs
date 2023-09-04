using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DivisionActivityPriority
{
    public string ActivityNo { get; set; } = null!;

    public string ResourceNumber { get; set; } = null!;

    public short Priority { get; set; }

    public string? AuditStamp { get; set; }
}
