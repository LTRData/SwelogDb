using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PriorPeriodTime
{
    public string ResourceNumber { get; set; } = null!;

    public int EmployeeNo { get; set; }

    public int? ActivityNo { get; set; }

    public string? ActivityType { get; set; }

    public DateTime? FromDateTime { get; set; }

    public decimal? ResourceTime { get; set; }

    public decimal? SetupTime { get; set; }

    public int? NoOfSetup { get; set; }

    public string? AuditStamp { get; set; }
}
