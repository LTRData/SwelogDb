using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerDeliveryStatusRep
{
    public string CustomerId { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
