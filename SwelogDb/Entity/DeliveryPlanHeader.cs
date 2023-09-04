using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DeliveryPlanHeader
{
    public string DeliveryPlanId { get; set; } = null!;

    public string CustomerNumber { get; set; } = null!;

    public string? CustomerOrderNumber { get; set; }

    public string? OurOrderNumber { get; set; }

    public string? DeliveryPlanType { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<DeliveryPlanIntermediate> DeliveryPlanIntermediates { get; } = new List<DeliveryPlanIntermediate>();
}
