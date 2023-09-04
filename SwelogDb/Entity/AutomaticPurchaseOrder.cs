using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AutomaticPurchaseOrder
{
    public string CustomerOrderNumber { get; set; } = null!;

    public string OrderType { get; set; } = null!;

    public short SequenceNumber { get; set; }

    public string? ItemNumber { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public string? AuditStamp { get; set; }
}
