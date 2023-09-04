using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ChangeProductStructureDtl
{
    public string ParentPart { get; set; } = null!;

    public string ComponentPart { get; set; } = null!;

    public string PositionIndicator { get; set; } = null!;

    public string? OperationList { get; set; }

    public short OperationNumber { get; set; }

    public string? OptionCode { get; set; }

    public decimal? OptionAddlPrice { get; set; }

    public decimal? QuantityOfComponent { get; set; }

    public string? ComponentUnitMeasure { get; set; }

    public string? CuttingIndicator { get; set; }

    public decimal? ScrapPercentage { get; set; }

    public DateTime? ComponentValidFrom { get; set; }

    public DateTime? ComponentValidTo { get; set; }

    public string? AuditStamp { get; set; }

    public int? ComponentPartTxtid { get; set; }

    public virtual UnitOfMeasure? ComponentUnitMeasureNavigation { get; set; }

    public virtual ChangeProductStructureHdr ParentPartNavigation { get; set; } = null!;
}
