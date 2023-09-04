using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DeliveryPlanAcceptArchiveHdr
{
    public int IdDeliveryPlanAcceptArchiveHdr { get; set; }

    public string? DeliveryPlanId { get; set; }

    public string? CustomerId { get; set; }

    public string ItemNo { get; set; } = null!;

    public DateTime? AcceptDate { get; set; }

    public DateTime? PlanDate { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidUpto { get; set; }

    public string? CustomerReference { get; set; }

    public string? PlanType { get; set; }

    public string? AuditStamp { get; set; }

    public string? PlanStatus { get; set; }
}
