using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemMarketPrice
{
    public string ItemNumber { get; set; } = null!;

    public string MarketCode { get; set; } = null!;

    public decimal? SalePriceCurrentCurrency { get; set; }

    public string? CurrencyCode { get; set; }

    public string? PriceUnit { get; set; }

    public string? AuditStamp { get; set; }

    public virtual CurrencyTable? CurrencyCodeNavigation { get; set; }

    public virtual Item ItemNumberNavigation { get; set; } = null!;

    public virtual Market MarketCodeNavigation { get; set; } = null!;

    public virtual UnitOfMeasure? PriceUnitNavigation { get; set; }
}
