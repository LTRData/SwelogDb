using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustInvPayBatch
{
    public string CompanyNo { get; set; } = null!;

    public string BatchNo { get; set; } = null!;

    public string? PayMode { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? Transferred { get; set; }

    public string? AuditStamp { get; set; }

    public virtual PaymentMode? PayModeNavigation { get; set; }
}
