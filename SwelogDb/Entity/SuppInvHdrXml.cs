using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SuppInvHdrXml
{
    public int RecNo { get; set; }

    public string? CompanyNo { get; set; }

    public string? InvoiceType { get; set; }

    public string? ArrivalSeries { get; set; }

    public decimal? ArrivalNo { get; set; }

    public string? InvoiceNo { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public DateTime? DueDate { get; set; }

    public string? SupplierNo { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? VatPercentage { get; set; }

    public decimal? InvAmountFc { get; set; }

    public decimal? VatAmountFc { get; set; }

    public decimal? RoundingAmountFc { get; set; }

    public string? PurchaserId { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public string? ItemNumber { get; set; }

    public string? ItemDescription { get; set; }

    public decimal? Quantity { get; set; }

    public string? UnitOfMeasure { get; set; }

    public string? OrderLineCurrencyCode { get; set; }

    public decimal? PurchasePriceFc { get; set; }

    public decimal? OrderLineDiscountPercentage { get; set; }

    public decimal? SetupPriceFc { get; set; }

    public short? PriceUnit { get; set; }

    public decimal? OrderDiscountPercentage { get; set; }

    public string? InvoiceCreated { get; set; }

    public string? InvoiceTypeXml { get; set; }
}
