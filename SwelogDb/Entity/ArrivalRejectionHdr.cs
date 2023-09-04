using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ArrivalRejectionHdr
{
    public string InspectionId { get; set; } = null!;

    public short InspectionSerial { get; set; }

    public string RejectionCode { get; set; } = null!;

    public decimal? RejectedQty { get; set; }

    public string? InspectorReference { get; set; }

    public string? FinalComment { get; set; }

    public string? RejectionHandleCode { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? QtyReviewed { get; set; }

    public string? ErrorReportId { get; set; }

    public string? ComplaintDetails { get; set; }

    public string? Printed { get; set; }

    public string? ComplaintNo { get; set; }

    public virtual ArrivalInspectionHdr Inspection { get; set; } = null!;
}
