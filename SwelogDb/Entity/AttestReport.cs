using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AttestReport
{
    public string ResourceNumber { get; set; } = null!;

    public DateTime ReportDateTime { get; set; }

    public string ActivityNo { get; set; } = null!;

    public string NotApproveCode { get; set; } = null!;

    public string AttestCode { get; set; } = null!;

    public decimal? AttestQty { get; set; }

    public int? AttestedBy { get; set; }

    public string? AuditStamp { get; set; }
}
