using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProductStructureArchive
{
    public int RecNo { get; set; }

    public DateTime? ArchiveDate { get; set; }

    public string? Userid { get; set; }

    public string? ParentPart { get; set; }

    public string? ComponentPart { get; set; }

    public string? PositionIndicator { get; set; }

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

    public string? AuditStamp { get; set; }

    public int? ComponentPartTxtid { get; set; }

    public string? DrawingNo { get; set; }

    public decimal? FixedUsage { get; set; }

    public decimal? OfferQuantity { get; set; }

    public string? WheeltablePosition { get; set; }
}
