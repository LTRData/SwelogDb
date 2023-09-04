using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class LiquidityHdr
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;

    public virtual FinancialYear FinancialYear { get; set; } = null!;
}
