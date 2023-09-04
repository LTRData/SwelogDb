using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ArrivalInspectionDtl
{
    public string InspectionId { get; set; } = null!;

    public short InspectionSerial { get; set; }

    public short OperationNumber { get; set; }

    public string MeasurePoint { get; set; } = null!;

    public decimal? MaxDimension { get; set; }

    public decimal? AvgDimension { get; set; }

    public decimal? MinDimension { get; set; }

    public decimal? RejectedQty { get; set; }

    public string? InspectorReference { get; set; }

    public string? InspectorComment { get; set; }

    public string? AuditStamp { get; set; }

    public string? MeasurePointDescription { get; set; }

    public decimal? Dimension { get; set; }

    public string? Property { get; set; }

    public decimal? ToleranceLower { get; set; }

    public decimal? ToleranceUpper { get; set; }

    public decimal? MeasuredValue { get; set; }

    public string? ApprovedYn { get; set; }

    public string? ScOrCc { get; set; }

    public virtual ArrivalInspectionOperation ArrivalInspectionOperation { get; set; } = null!;

    public virtual ICollection<ArrivalRejectionDtl> ArrivalRejectionDtls { get; } = new List<ArrivalRejectionDtl>();
}
