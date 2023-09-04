using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwFactCo
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public DateTime? OrderDate { get; set; }

    public string? PartnerId { get; set; }

    public string? PartnerOwnOrderNo { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? OrderTotalAmount { get; set; }

    public string? FinalDeliveryFlag { get; set; }

    public string? OrderStatus { get; set; }

    public string? OurReference { get; set; }

    public string? SalesmanCode { get; set; }

    public string? SalesmanName { get; set; }

    public string? TerritoryCode { get; set; }

    public string? TerritoryDesc { get; set; }

    public string? MarketCode { get; set; }

    public string? MarketDescription { get; set; }

    public string? AContoInvoiceFlag { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerCategory { get; set; }

    public short OrderLineNumber { get; set; }

    public DateTime PlannedDeliveryDate { get; set; }

    public string? ItemNumber { get; set; }

    public string? OrderLineType { get; set; }

    public string? GoodsDescription { get; set; }

    public decimal? OrderQuantity { get; set; }

    public string? UnitOfSale { get; set; }

    public string? UnitOfStock { get; set; }

    public DateTime? DesiredDeliveryDate { get; set; }

    public DateTime? PromisedDeliveryDate { get; set; }

    public decimal? SellingPrice { get; set; }

    public decimal? OrderedAmount { get; set; }

    public short? PriceUnit { get; set; }

    public string? VatCode { get; set; }

    public decimal? ActualDeliveredQuantity { get; set; }

    public string? DeliveryStatus { get; set; }

    public string? OrderLineStatus { get; set; }

    public string? FullyDeliver { get; set; }

    public decimal? CostPriceCo { get; set; }

    public decimal? CostPriceItem { get; set; }

    public short? PriceUnitItem { get; set; }

    public string? CostPriceExchangeCurrency { get; set; }

    public decimal? CostPriceExchangeRate { get; set; }

    public decimal? OrderDateCurrencyRate { get; set; }

    public string? CompanyNo { get; set; }

    public string? InvoiceType { get; set; }

    public string? InvoiceSeries { get; set; }

    public decimal? InvoiceNo { get; set; }

    public decimal? InvoiceSellingPrice { get; set; }

    public decimal? InvoiceQty { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public DateTime? DueDate { get; set; }

    public string? InvoicePaymentTerm { get; set; }

    public decimal? OriginalRate { get; set; }

    public decimal? NetInvAmtFc { get; set; }

    public decimal? NetInvAmtBc { get; set; }

    public decimal? VatAmtFc { get; set; }

    public decimal? VatAmtBc { get; set; }

    public decimal? LineAmtFc { get; set; }

    public decimal? LineAmtBc { get; set; }

    public decimal? PaidAmtFc { get; set; }

    public decimal? PaidAmtBc { get; set; }
}
