using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EcoestmtCostpriceTransferListHdr
{
    public string ListId { get; set; } = null!;

    public string? ListDescription { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<EcoestmtCostpriceTransferListDtl> EcoestmtCostpriceTransferListDtls { get; } = new List<EcoestmtCostpriceTransferListDtl>();
}
