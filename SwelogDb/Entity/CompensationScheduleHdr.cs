using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CompensationScheduleHdr
{
    public string CompScheduleId { get; set; } = null!;

    public string PersonCatg { get; set; } = null!;

    public DateTime ScheduleValidFrom { get; set; }

    public DateTime? ScheduleValidUntil { get; set; }

    public string? ScheduleDescription { get; set; }

    public string? AuditStamp { get; set; }
}
