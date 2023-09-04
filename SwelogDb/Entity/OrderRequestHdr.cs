using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderRequestHdr
{
    public int RequestSerialNumber { get; set; }

    public string? CustomerId { get; set; }

    public string? Text { get; set; }

    public string? DeliveryAddressId { get; set; }

    public string? ActualOrderNumber { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<OrderRequestDtl> OrderRequestDtls { get; } = new List<OrderRequestDtl>();
}
