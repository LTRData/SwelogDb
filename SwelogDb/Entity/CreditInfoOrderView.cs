using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CreditInfoOrderView
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public string? PartnerId { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal OrderTotalAmount { get; set; }

    public decimal OrderTotalDiscount { get; set; }

    public decimal? OrderNetAmt { get; set; }

    public decimal? CurrencyUnits { get; set; }

    public decimal SellingRate { get; set; }

    public decimal CurrentExchangeRate { get; set; }

    public decimal? NetOrderAmtBase { get; set; }
}
