using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ArrivalRejectionDtl
{
    public string InspectionId { get; set; } = null!;

    public short InspectionSerial { get; set; }

    public short OperationNumber { get; set; }

    public string MeasurePoint { get; set; } = null!;

    public string RejectionCode { get; set; } = null!;

    public decimal? RejectedQty { get; set; }

    public string? InspectorComment { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? MeasuredValue { get; set; }

    public decimal? Dimension { get; set; }

    public decimal? ToleranceLower { get; set; }

    public decimal? ToleranceUpper { get; set; }

    public string? PalletNo { get; set; }

    public virtual ArrivalInspectionDtl ArrivalInspectionDtl { get; set; } = null!;
}
