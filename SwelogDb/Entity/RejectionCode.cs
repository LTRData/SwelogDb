using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class RejectionCode
{
    public string RejectionCode1 { get; set; } = null!;

    public string? RejectionDesc { get; set; }

    public double? RejectionDescTxtid { get; set; }

    public string? RejectionDescFlag { get; set; }

    public string? MfgInd { get; set; }

    public string? AuditStamp { get; set; }

    public string? PurchaseInd { get; set; }

    public virtual ICollection<RejectReport> RejectReports { get; } = new List<RejectReport>();
}
