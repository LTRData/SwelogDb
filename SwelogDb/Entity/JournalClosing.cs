using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class JournalClosing
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public decimal LineNo { get; set; }

    public string? AccountNo { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? ExchangeRate { get; set; }

    public decimal? AmountFc { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? VoucherDate { get; set; }

    public string? AuditStamp { get; set; }

    public virtual Account? Account { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;

    public virtual FinancialYear FinancialYear { get; set; } = null!;
}
