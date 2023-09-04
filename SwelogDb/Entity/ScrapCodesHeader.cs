using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ScrapCodesHeader
{
    public string ScrapCode { get; set; } = null!;

    public string? ScrapCodeDescription { get; set; }

    public string? UnitOfMeasure { get; set; }

    public byte? AverageRateMonths { get; set; }

    public string? AuditStamp { get; set; }
}
