using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SuppInvPayBatch
{
    public string CompanyNo { get; set; } = null!;

    public string BatchNo { get; set; } = null!;

    public string? PrelPaid { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? TransferredToBank { get; set; }

    public string? Transferred { get; set; }

    public string? AuditStamp { get; set; }

    public string? FileType { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;
}
