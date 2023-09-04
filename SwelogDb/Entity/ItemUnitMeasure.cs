using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemUnitMeasure
{
    public string ItemNumber { get; set; } = null!;

    public string StockingUnit { get; set; } = null!;

    public string AlternateUnit { get; set; } = null!;

    public string? TypeOfUnit { get; set; }

    public decimal? UnitConversionFactor { get; set; }

    public decimal? PriceConversionFactor { get; set; }

    public decimal? ConversionFrom { get; set; }

    public string? AuditStamp { get; set; }

    public virtual UnitOfMeasure AlternateUnitNavigation { get; set; } = null!;

    public virtual UnitOfMeasure StockingUnitNavigation { get; set; } = null!;
}
