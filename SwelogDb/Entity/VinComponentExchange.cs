using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VinComponentExchange
{
    public int IdVinComponentExchange { get; set; }

    public DateTime ExchangeDateTime { get; set; }

    public string VinNumber { get; set; } = null!;

    public string InOut { get; set; } = null!;

    public string? ItemNumber { get; set; }

    public decimal? Quantity { get; set; }

    public string? OldItemNumber { get; set; }

    public decimal? OldQuantity { get; set; }

    public string? AuditStamp { get; set; }
}
