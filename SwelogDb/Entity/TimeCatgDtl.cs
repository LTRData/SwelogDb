using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TimeCatgDtl
{
    public string TimeCatg { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public short DaySerial { get; set; }

    public string? WkSchedule { get; set; }

    public string? AuditStamp { get; set; }

    public short? OldMethod { get; set; }
}
