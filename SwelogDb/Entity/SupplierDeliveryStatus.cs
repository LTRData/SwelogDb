using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SupplierDeliveryStatus
{
    public string DeliveryStatus { get; set; } = null!;

    public string? DeliveryStatusDescription { get; set; }

    public string? AuditStamp { get; set; }
}
