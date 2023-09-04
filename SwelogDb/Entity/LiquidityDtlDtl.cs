using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class LiquidityDtlDtl
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public int RecNo { get; set; }

    public decimal PeriodNo { get; set; }

    public byte DayNo { get; set; }

    public byte? WeekNo { get; set; }

    public int? AmountDayNo { get; set; }

    public string? AuditStamp { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;

    public virtual FinancialPeriod FinancialPeriod { get; set; } = null!;

    public virtual FinancialYear FinancialYear { get; set; } = null!;
}
