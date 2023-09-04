using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DistributionListDtl
{
    public string DistributionListId { get; set; } = null!;

    public string DistributionTo { get; set; } = null!;

    public short? NoOfCopies { get; set; }

    public DateTime? ListEffectiveFrom { get; set; }

    public DateTime? ListEffectiveUntil { get; set; }

    public string? AuditStamp { get; set; }

    public virtual DistributionListHdr DistributionList { get; set; } = null!;
}
