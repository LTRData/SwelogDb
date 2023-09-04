using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrossCurrency
{
    public string CurrencyExchangePlace { get; set; } = null!;

    public DateTime XCurrencyDate { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string XCurrencyCode { get; set; } = null!;

    public decimal? XCurrencyRate { get; set; }

    public decimal? CurrencyUnits { get; set; }

    public string? AuditStamp { get; set; }

    public virtual CurrencyTable CurrencyCodeNavigation { get; set; } = null!;

    public virtual CurrencyTable XCurrencyCodeNavigation { get; set; } = null!;
}
