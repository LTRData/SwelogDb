using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NotApproveCode
{
    public string NotApproveCode1 { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidUpto { get; set; }

    public string? NotApproveDescription { get; set; }

    public string? RejectionCode { get; set; }

    public string? AuditStamp { get; set; }
}
