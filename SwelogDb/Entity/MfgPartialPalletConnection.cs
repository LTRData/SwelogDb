using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgPartialPalletConnection
{
    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public string? PartialPalletNo { get; set; }

    public int? OperationNumber { get; set; }

    public decimal? Quantity { get; set; }

    public string? AuditStamp { get; set; }
}
