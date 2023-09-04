using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwFactProductStructure
{
    public string ParentPart { get; set; } = null!;

    public string? ParentItemDescription { get; set; }

    public string? ParentExtraItemDescription { get; set; }

    public string ComponentPart { get; set; } = null!;

    public string? ComponentItemDescription { get; set; }

    public string? ComponentExtraItemDescription { get; set; }

    public short OperationNumber { get; set; }

    public decimal? QuantityOfComponent { get; set; }

    public string PositionIndicator { get; set; } = null!;

    public string? ComponentUnitMeasure { get; set; }

    public DateTime? ComponentValidFrom { get; set; }

    public DateTime? ComponentValidTo { get; set; }
}
