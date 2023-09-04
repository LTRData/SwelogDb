using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EcoestmtCostpriceTransferListDtl
{
    public string ListId { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public virtual EcoestmtCostpriceTransferListHdr List { get; set; } = null!;
}
