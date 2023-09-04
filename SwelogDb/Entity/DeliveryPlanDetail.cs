using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DeliveryPlanDetail
{
    public string DeliveryPlanId { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public string DeliveryAddressId { get; set; } = null!;

    public DateTime DeliveryDate { get; set; }

    public decimal DesiredQuantity { get; set; }

    public decimal? CumulativeReceiptQuantity { get; set; }

    public string? DeliveryStatus { get; set; }

    public string? AuditStamp { get; set; }

    public virtual DeliveryPlanIntermediate DeliveryPlanIntermediate { get; set; } = null!;
}
