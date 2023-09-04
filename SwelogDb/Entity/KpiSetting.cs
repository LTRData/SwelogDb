using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class KpiSetting
{
    public string UserId { get; set; } = null!;

    public int ViewNumber { get; set; }

    public int KpiId { get; set; }

    public string? UserValues { get; set; }

    public bool? Active { get; set; }

    public string? AuditStamp { get; set; }

    public int? RedValue { get; set; }

    public int? YellowValue { get; set; }
}
