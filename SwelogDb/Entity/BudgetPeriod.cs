using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BudgetPeriod
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string BudgetNo { get; set; } = null!;

    public decimal BudgetAccountId { get; set; }

    public decimal PeriodNo { get; set; }

    public decimal? Amount { get; set; }

    public string? AuditStamp { get; set; }
}
