using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NetPlanPurchase
{
    public int NetPlanId { get; set; }

    public short SequenceNumber { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public string? ItemNumber { get; set; }

    public short? OperationNumber { get; set; }

    public decimal? DerivedOrderQty { get; set; }

    public DateTime? PurchaseItemRequiredDate { get; set; }

    public string? AuditStamp { get; set; }
}
