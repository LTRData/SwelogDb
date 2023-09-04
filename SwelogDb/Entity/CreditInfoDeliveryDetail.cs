using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CreditInfoDeliveryDetail
{
    public string OrderNumber { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public double? DeliveryQuantity { get; set; }

    public string DeliveryNoteNumber { get; set; } = null!;

    public string? PartnerId { get; set; }

    public string? InvoiceFlag { get; set; }

    public decimal? SellingPrice { get; set; }

    public decimal DiscountPercentage { get; set; }

    public decimal SetupPrice { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal PartnerDiscountPercentile { get; set; }

    public decimal? CurrencyUnits { get; set; }

    public decimal SellingRate { get; set; }

    public decimal CurrentExchangeRate { get; set; }

    public double? GrossLineAmt { get; set; }

    public double? LineAmt { get; set; }

    public double? NetAmt { get; set; }

    public double? NetAmtBase { get; set; }
}
