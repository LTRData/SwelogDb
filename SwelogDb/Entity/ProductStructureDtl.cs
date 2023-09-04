using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProductStructureDtl
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

    public string? DrawingNo { get; set; }

    public decimal? FixedUsage { get; set; }

    public decimal? OfferQuantity { get; set; }

    public string? WheeltablePosition { get; set; }

    public string? Comments { get; set; }

    public decimal? ProcessTime { get; set; }

    public bool? MeasurementRequired { get; set; }

    public decimal? RequiredValue { get; set; }

    public decimal? MaximumValue { get; set; }

    public virtual UnitOfMeasure? ComponentUnitMeasureNavigation { get; set; }

    public virtual ProductStructureHdr ParentPartNavigation { get; set; } = null!;
}
