using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CreditInfoInvoice
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string InvoiceType { get; set; } = null!;

    public string InvoiceSeries { get; set; } = null!;

    public decimal InvoiceNo { get; set; }

    public string? CustomerNo { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal RoundingAmtFc { get; set; }

    public decimal NetInvAmtFc { get; set; }

    public decimal VatAmtFc { get; set; }

    public decimal? CurrencyUnits { get; set; }

    public decimal CurrentExchangeRate { get; set; }

    public decimal SellingRate { get; set; }

    public decimal PayAmtFc { get; set; }

    public decimal ServiceCost { get; set; }

    public decimal? OtherCosts { get; set; }

    public decimal? OtherCostsBc { get; set; }

    public decimal? InvoiceAmt { get; set; }

    public decimal? PaidAmt { get; set; }

    public decimal? InvoicedNotPaidAmt { get; set; }
}
