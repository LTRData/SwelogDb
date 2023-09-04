using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PmErrand
{
    public int IdPmErrand { get; set; }

    public string ErrandDescription { get; set; } = null!;

    public string? ItemNumber { get; set; }

    public string? AuditStamp { get; set; }
}
