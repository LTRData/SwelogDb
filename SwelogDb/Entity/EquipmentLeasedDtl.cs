using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EquipmentLeasedDtl
{
    public string CompanyNo { get; set; } = null!;

    public string LeasingNo { get; set; } = null!;

    public short PeriodNo { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public decimal? BudgetAmountPeriod { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? PayAmtBc { get; set; }

    public virtual EquipmentLeasedHdr EquipmentLeasedHdr { get; set; } = null!;
}
