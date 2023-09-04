using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class InternalOrder
{
    public string InternalOrderNo { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public DateTime? InternalOrderDate { get; set; }

    public decimal? InternalOrderQty { get; set; }

    public DateTime? OrderReadyDate { get; set; }

    public string? StockLocation { get; set; }

    public string? WarehouseId { get; set; }

    public decimal? AllocatedQuantity { get; set; }

    public string? InternalOrderStatus { get; set; }

    public string? AuditStamp { get; set; }
}
