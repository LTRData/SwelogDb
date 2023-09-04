using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BudgetAmt
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string BudgetType { get; set; } = null!;

    public string BudgetNo { get; set; } = null!;

    public decimal LineNo { get; set; }

    public decimal PeriodNo { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public decimal? Percentage { get; set; }

    public decimal? AmountFc { get; set; }

    public decimal? AmountBc { get; set; }

    public string? AuditStamp { get; set; }

    public virtual BudgetDtl BudgetDtl { get; set; } = null!;
}
