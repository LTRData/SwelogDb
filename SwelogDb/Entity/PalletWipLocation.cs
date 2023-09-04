using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PalletWipLocation
{
    public string PalletNo { get; set; } = null!;

    public int OperationNumber { get; set; }

    public string? StoreLocation { get; set; }

    public string? AuditStamp { get; set; }

    public string? StockPosition { get; set; }

    public int? QtyAdjusted { get; set; }
}
