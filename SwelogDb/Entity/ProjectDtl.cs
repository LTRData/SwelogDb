using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProjectDtl
{
    public string CompanyNo { get; set; } = null!;

    public string ProjectNo { get; set; } = null!;

    public int RecNo { get; set; }

    public string? SupplierId { get; set; }

    public string? Text { get; set; }

    public string? ArrivalSeries { get; set; }

    public int? ArrivalNo { get; set; }

    public decimal? BudgetAmountBc { get; set; }

    public decimal? InvAmountBc { get; set; }

    public string? AuditStamp { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public string? LineType { get; set; }

    public string? AccountNo { get; set; }

    public int? RefLineNo { get; set; }

    public string? CustomerId { get; set; }

    public virtual Project Project { get; set; } = null!;
}
