using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class WagePreparation
{
    public string WageCategory { get; set; } = null!;

    public string WagePeriod { get; set; } = null!;

    public DateTime WagePeriodStart { get; set; }

    public DateTime WagePeriodEnd { get; set; }

    public DateTime PrepareDate { get; set; }

    public DateTime? SalaryConnectDate { get; set; }

    public string? AuditStamp { get; set; }
}
