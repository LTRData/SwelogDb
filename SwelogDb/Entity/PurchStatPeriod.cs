using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PurchStatPeriod
{
    public int PeriodId { get; set; }

    public string PeriodDesc { get; set; } = null!;

    public DateTime FromDate { get; set; }

    public DateTime UptoDate { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<PurchStatTargetPerItem> PurchStatTargetPerItems { get; } = new List<PurchStatTargetPerItem>();

    public virtual ICollection<PurchStatTargetPerProdGroup> PurchStatTargetPerProdGroups { get; } = new List<PurchStatTargetPerProdGroup>();
}
