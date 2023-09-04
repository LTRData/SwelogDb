using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ExtraCompScheduleHdr
{
    public string ExtraCompScheduleId { get; set; } = null!;

    public string PersonCatg { get; set; } = null!;

    public DateTime ScheduleValidFrom { get; set; }

    public DateTime? ScheduleValidUntil { get; set; }

    public string? ExtraCompScheduleDesc { get; set; }

    public string? AuditStamp { get; set; }
}
