using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BudgetHdrHdrDept
{
    public string CompanyNo { get; set; } = null!;

    public short YearNo { get; set; }

    public string BudgetNo { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public virtual ICollection<BudgetHdrDept> BudgetHdrDepts { get; } = new List<BudgetHdrDept>();
}
