using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderStatus
{
    public string OrderStatusId { get; set; } = null!;

    public string? OrderStatusDesc { get; set; }

    public int? OrderStatusDescTxtid { get; set; }

    public string? OrderStatusDescFlag { get; set; }

    public string? AuditStamp { get; set; }
}
