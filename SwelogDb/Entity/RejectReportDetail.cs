using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class RejectReportDetail
{
    public string ResourceNumber { get; set; } = null!;

    public DateTime ReportDateTime { get; set; }

    public string ActivityNo { get; set; } = null!;

    public string NotApproveCode { get; set; } = null!;

    public string RejectCode { get; set; } = null!;

    public decimal? RejectQty { get; set; }

    public string? AuditStamp { get; set; }
}
