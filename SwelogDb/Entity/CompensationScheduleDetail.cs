using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CompensationScheduleDetail
{
    public string CompScheduleId { get; set; } = null!;

    public string PersonCatg { get; set; } = null!;

    public DateTime ScheduleValidFrom { get; set; }

    public string CompensationCode { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
