using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemInspDtl
{
    public int SerialNumber { get; set; }

    public string ItemNumber { get; set; } = null!;

    public string MeasurePoint { get; set; } = null!;

    public string? MeasurePointDescription { get; set; }

    public decimal? Dimension { get; set; }

    public decimal? ToleranceLower { get; set; }

    public decimal? ToleranceUpper { get; set; }

    public string? ToolNumber { get; set; }

    public string? AuditStamp { get; set; }

    public string? Property { get; set; }

    public int? LotNumber { get; set; }

    public bool? Active { get; set; }

    public string? PercRrOrPt { get; set; }

    public string? ScOrCc { get; set; }

    public string? Judgement { get; set; }

    public string? PartNumber { get; set; }

    public decimal? InspectionFrequency { get; set; }

    public decimal? InspectionQuantity { get; set; }

    public string? MeasurementTechnique { get; set; }

    public int? OperationNumber { get; set; }

    public int? PropertyTxtid { get; set; }

    public int? MeasurementTechniqueTxtid { get; set; }

    public int? JudgementTxtid { get; set; }

    public int? NumberOfCases { get; set; }

    public virtual ICollection<ItemInspDtlDtl> ItemInspDtlDtls { get; } = new List<ItemInspDtlDtl>();
}
