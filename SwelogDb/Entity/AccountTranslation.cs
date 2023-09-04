using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AccountTranslation
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string AccountSending { get; set; } = null!;

    public string? AccountReceiving { get; set; }

    public decimal? ReceivingYearNo { get; set; }

    public string? AuditStamp { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual Company CompanyNoNavigation { get; set; } = null!;

    public virtual FinancialYear? FinancialYear { get; set; }

    public virtual FinancialYear FinancialYearNavigation { get; set; } = null!;
}
