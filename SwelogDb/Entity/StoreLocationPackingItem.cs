using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class StoreLocationPackingItem
{
    public string WarehouseId { get; set; } = null!;

    public string LocationId { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public decimal? Quantity { get; set; }

    public DateTime? BalanceDate { get; set; }

    public decimal? QuantityIssued { get; set; }

    public decimal? QuantityReceived { get; set; }

    public string? AuditStamp { get; set; }
}
