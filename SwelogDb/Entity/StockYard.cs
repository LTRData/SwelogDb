using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class StockYard
{
    public string WarehouseId { get; set; } = null!;

    public string StockYard1 { get; set; } = null!;

    public string? YardName { get; set; }

    public string? AuditStamp { get; set; }
}
