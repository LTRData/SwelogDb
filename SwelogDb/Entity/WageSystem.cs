using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class WageSystem
{
    public string WageSystem1 { get; set; } = null!;

    public DateTime? WageSystemValidFrom { get; set; }

    public DateTime? WageSystemValidUpto { get; set; }

    public string? WageSystemDescription { get; set; }

    public string? Remarks { get; set; }

    public string? AuditStamp { get; set; }

    public string? CalendarTransOption { get; set; }
}
