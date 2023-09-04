using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AlloyCodesHeader
{
    public string AlloyCode { get; set; } = null!;

    public string? AlloyCodeDescription { get; set; }

    public string? UnitOfMeasure { get; set; }

    public string? AuditStamp { get; set; }

    public byte? AverageRateMonths { get; set; }
}
