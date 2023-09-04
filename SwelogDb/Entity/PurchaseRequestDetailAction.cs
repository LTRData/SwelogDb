using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PurchaseRequestDetailAction
{
    public int IdPurchaseRequestDetailAction { get; set; }

    public int? DetailId { get; set; }

    public DateTime? ActionDate { get; set; }

    public string? ActionDescription { get; set; }

    public string? AuditStamp { get; set; }
}
