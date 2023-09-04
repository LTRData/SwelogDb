using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OpenOrderHdr
{
    public int LotNumber { get; set; }

    public string ItemNumber { get; set; } = null!;

    public decimal? OrderedQuantity { get; set; }

    public DateTime? MfgOrderStartDate { get; set; }

    public DateTime? MfgOrderFinishDate { get; set; }

    public string? AuditStamp { get; set; }
}
