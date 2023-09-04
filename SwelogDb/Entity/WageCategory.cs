using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class WageCategory
{
    public string WageCategory1 { get; set; } = null!;

    public DateTime WageCatgValidFrom { get; set; }

    public DateTime? WageCatgValidUpto { get; set; }

    public string? WageCatgDescription { get; set; }

    public DateTime? WagePrepareDate { get; set; }

    public string? AuditStamp { get; set; }

    public short? OutputOptions { get; set; }

    public string? WageSystem { get; set; }

    public int? SavedPeriod { get; set; }
}
