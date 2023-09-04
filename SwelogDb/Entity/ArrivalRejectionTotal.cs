using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ArrivalRejectionTotal
{
    public string InspectionId { get; set; } = null!;

    public string RejectionCode { get; set; } = null!;

    public decimal? RejectedQty { get; set; }

    public string? AuditStamp { get; set; }

    public virtual GoodsEntry Inspection { get; set; } = null!;
}
