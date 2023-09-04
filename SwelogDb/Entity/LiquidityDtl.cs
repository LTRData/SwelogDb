using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class LiquidityDtl
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public int RecNo { get; set; }

    public string? Description { get; set; }

    public string? PlusMinus { get; set; }

    public string? FetchType { get; set; }

    public string? AccountNo { get; set; }

    public int? AmountPeriod1 { get; set; }

    public int? AmountPeriod2 { get; set; }

    public int? AmountPeriod3 { get; set; }

    public int? AmountPeriod4 { get; set; }

    public int? AmountPeriod5 { get; set; }

    public int? AmountPeriod6 { get; set; }

    public int? AmountPeriod7 { get; set; }

    public int? AmountPeriod8 { get; set; }

    public int? AmountPeriod9 { get; set; }

    public int? AmountPeriod10 { get; set; }

    public int? AmountPeriod11 { get; set; }

    public int? AmountPeriod12 { get; set; }

    public string? AuditStamp { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;

    public virtual FinancialYear FinancialYear { get; set; } = null!;
}
