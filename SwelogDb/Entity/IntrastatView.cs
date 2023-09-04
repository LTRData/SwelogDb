using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class IntrastatView
{
    public int SerealNo { get; set; }

    public string IntrastatCode { get; set; } = null!;

    public string EuCode { get; set; } = null!;

    public DateTime? ArrivalDate { get; set; }

    public string? TariffCode { get; set; }

    public string? TransactionType { get; set; }

    public string? TransportMode { get; set; }

    public decimal? NetWeight { get; set; }

    public string? OtherQuantity { get; set; }

    public string? OrderNumber { get; set; }

    public decimal? StatValue { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public string? OrderType { get; set; }

    public short? OrderLineNumber { get; set; }

    public short? OrderLineNumberSub { get; set; }

    public string? GoodsEntryNo { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? InvoiceSeries { get; set; }

    public decimal? InvoiceNo { get; set; }

    public decimal? DisPercentage { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? OriginalRate { get; set; }

    public string? ItemNo { get; set; }

    public decimal? StockQuantity { get; set; }

    public decimal? ConversionFactor { get; set; }

    public string? UnitOfStock { get; set; }

    public string? AlternateUnit { get; set; }

    public decimal? ConvertedQty { get; set; }

    public decimal? Units { get; set; }

    public decimal? Rate { get; set; }

    public decimal? LineAmtFc { get; set; }

    public decimal? OrderHdrDisPercentage { get; set; }

    public decimal? LineAmtBc { get; set; }

    public int NetValueFc { get; set; }

    public decimal? NetValue { get; set; }

    public string? CountryOfOrigin { get; set; }

    public string? VatRegNo { get; set; }
}
