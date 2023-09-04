using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrossUnitMeasure
{
    public string UnitMeasureCode { get; set; } = null!;

    public string XUnitMeasure { get; set; } = null!;

    public decimal? ConversionFactor { get; set; }

    public decimal? ConversionFrom { get; set; }

    public string? AuditStamp { get; set; }

    public virtual UnitOfMeasure UnitMeasureCodeNavigation { get; set; } = null!;

    public virtual UnitOfMeasure XUnitMeasureNavigation { get; set; } = null!;
}
