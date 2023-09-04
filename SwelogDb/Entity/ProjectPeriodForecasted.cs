using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProjectPeriodForecasted
{
    public string CompanyNo { get; set; } = null!;

    public string ProjectNo { get; set; } = null!;

    public short PeriodNo { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public decimal? BudgetAmountPeriod { get; set; }

    public string? AuditStamp { get; set; }

    public virtual Project Project { get; set; } = null!;
}
