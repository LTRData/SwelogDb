using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class WeekSchMain
{
    public string WkSchedule { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidUntil { get; set; }

    public string? ScheduleDesc { get; set; }

    public string? AuditStamp { get; set; }
}
