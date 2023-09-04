using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwSellingPricePerItem
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string InvoiceType { get; set; } = null!;

    public string InvoiceSeries { get; set; } = null!;

    public decimal InvoiceNo { get; set; }

    public string? CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? ItemNumber { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? LineAmountWithSetup { get; set; }

    public decimal? SetupPriceInFc { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? SetupPriceInBc { get; set; }

    public short? PriceUnit { get; set; }

    public decimal? LineAmountWithoutSetup { get; set; }

    public decimal? SellingPricePerUnit { get; set; }

    public decimal? SellingPricePerPriceUnit { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? CurrFormat { get; set; }
}
