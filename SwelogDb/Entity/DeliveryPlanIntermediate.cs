using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DeliveryPlanIntermediate
{
    public string DeliveryPlanId { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public string? CustomerItemNumber { get; set; }

    public string? PlanStatus { get; set; }

    public string? Remark { get; set; }

    public string? AuditStamp { get; set; }

    public virtual DeliveryPlanHeader DeliveryPlan { get; set; } = null!;

    public virtual ICollection<DeliveryPlanDetail> DeliveryPlanDetails { get; } = new List<DeliveryPlanDetail>();
}
