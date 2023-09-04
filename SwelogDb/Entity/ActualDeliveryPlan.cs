using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ActualDeliveryPlan
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public short OrderLineNumber { get; set; }

    public short OrderLineNumberSub { get; set; }

    public string ItemNumber { get; set; } = null!;

    public string DeliveryAddressId { get; set; } = null!;

    public DateTime DeliveryDate { get; set; }

    public string? CustomerNumber { get; set; }

    public string? CustomerItemNumber { get; set; }

    public decimal DesiredQuantity { get; set; }

    public decimal? DeliveredQuantity { get; set; }

    public string? DeliveryStatus { get; set; }

    public string? Remark { get; set; }

    public string? AuditStamp { get; set; }
}
