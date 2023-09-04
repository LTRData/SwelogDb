using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpProductStructure
{
    public int ProcessId { get; set; }

    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public string ParentPart { get; set; } = null!;

    public string ComponentPart { get; set; } = null!;

    public string PositionIndicator { get; set; } = null!;

    public int OperationNumber { get; set; }

    public DateTime? StructureValidFrom { get; set; }

    public string? ParentUnitMeasure { get; set; }

    public decimal? QuantityOfParent { get; set; }

    public decimal? QuantityOfComponent { get; set; }

    public string? ComponentUnitMeasure { get; set; }

    public decimal? ScrapPercentage { get; set; }

    public DateTime? ComponentValidFrom { get; set; }

    public DateTime? ComponentValidTo { get; set; }

    public int? ComponentPartTxtid { get; set; }
}
