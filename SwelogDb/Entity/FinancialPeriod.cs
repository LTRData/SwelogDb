using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class FinancialPeriod
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public decimal PeriodNo { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal BookClosed { get; set; }

    public string? AuditStamp { get; set; }

    public string? ClosingEntryPeriod { get; set; }

    public virtual FinancialYear FinancialYear { get; set; } = null!;

    public virtual ICollection<LiquidityDtlDtl> LiquidityDtlDtls { get; } = new List<LiquidityDtlDtl>();
}
