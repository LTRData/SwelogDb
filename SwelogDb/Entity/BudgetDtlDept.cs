using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BudgetDtlDept
{
    public string CompanyNo { get; set; } = null!;

    public short YearNo { get; set; }

    public string BudgetNo { get; set; } = null!;

    public string AccountNo { get; set; } = null!;

    public string DepartmentNo { get; set; } = null!;

    public short? BudgetDtlLineNo { get; set; }

    public decimal? Percentage { get; set; }

    public string? AuditStamp { get; set; }

    public virtual BudgetHdrDept BudgetHdrDept { get; set; } = null!;
}
