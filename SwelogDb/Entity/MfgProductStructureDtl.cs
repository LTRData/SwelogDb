using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgProductStructureDtl
{
    public string ParentPart { get; set; } = null!;

    public string ComponentPart { get; set; } = null!;

    public string PositionIndicator { get; set; } = null!;

    public string? OperationList { get; set; }

    public short? OperationNumber { get; set; }

    public string? OptionCode { get; set; }

    public decimal? OptionAddlPrice { get; set; }

    public decimal? QuantityOfComponent { get; set; }

    public string? ComponentUnitMeasure { get; set; }

    public string? CuttingIndicator { get; set; }

    public decimal? ScrapPercentage { get; set; }

    public DateTime? ComponentValidFrom { get; set; }

    public DateTime? ComponentValidTo { get; set; }

    public short? PageNumber { get; set; }

    public decimal? TotalQuantity { get; set; }

    public decimal? IssuedQuantity { get; set; }

    public string? AuditStamp { get; set; }

    public int? PositionIndicatorTxtid { get; set; }

    public virtual MfgProductStructureHdr ParentPartNavigation { get; set; } = null!;
}
