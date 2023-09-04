using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BudgetHdrDept
{
    public string CompanyNo { get; set; } = null!;

    public short YearNo { get; set; }

    public string BudgetNo { get; set; } = null!;

    public string AccountNo { get; set; } = null!;

    public string? AllocationKeyNo { get; set; }

    public decimal? AmountBc { get; set; }

    public string? BudgetGenerated { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<BudgetDtlDept> BudgetDtlDepts { get; } = new List<BudgetDtlDept>();

    public virtual BudgetHdrHdrDept BudgetHdrHdrDept { get; set; } = null!;
}
