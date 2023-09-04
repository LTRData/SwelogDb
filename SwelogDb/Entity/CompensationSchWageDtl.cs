using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CompensationSchWageDtl
{
    public string CompScheduleId { get; set; } = null!;

    public string PersonCatg { get; set; } = null!;

    public DateTime ScheduleValidFrom { get; set; }

    public string CompensationCode { get; set; } = null!;

    public DateTime WorkTimeStartFrom { get; set; }

    public string WageType { get; set; } = null!;

    public DateTime? WorkTimeStartUpto { get; set; }

    public string? AuditStamp { get; set; }
}
