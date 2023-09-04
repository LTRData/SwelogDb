using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class RejectReport
{
    public string ResourceNumber { get; set; } = null!;

    public DateTime ReportDatetime { get; set; }

    public int ActivityNo { get; set; }

    public string RejectionCode { get; set; } = null!;

    public decimal? QtyRejected { get; set; }

    public int? RejectedBy { get; set; }

    public string? AuditStamp { get; set; }

    public virtual RejectionCode RejectionCodeNavigation { get; set; } = null!;
}
