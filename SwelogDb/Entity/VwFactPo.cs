using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwFactPo
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public DateTime? OrderDate { get; set; }

    public string? PartnerId { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? OrderTotalAmount { get; set; }

    public string? FinalDeliveryFlag { get; set; }

    public string? OrderStatus { get; set; }

    public string? OurReference { get; set; }

    public string? TerritoryCode { get; set; }

    public string? MarketCode { get; set; }

    public string? SupplierName { get; set; }

    public string? SupplierCategoryCode { get; set; }

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

    public short? OperationNumber { get; set; }

    public decimal? SellingPrice { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? OrderedAmount { get; set; }

    public short? PriceUnit { get; set; }

    public string? VatCode { get; set; }

    public decimal? ActualDeliveredQuantity { get; set; }

    public decimal? DeliveredStockUnits { get; set; }

    public string? ProductGroup { get; set; }

    public string? DeliveryStatus { get; set; }

    public string? OrderLineStatus { get; set; }

    public string? CompanyNo { get; set; }

    public string? InvoiceType { get; set; }

    public string? ArrivalSeries { get; set; }

    public decimal? ArrivalNo { get; set; }

    public string? InvoiceNo { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public DateTime? DueDate { get; set; }

    public string? PaymentTermSuppInvoice { get; set; }

    public decimal? OriginalRate { get; set; }

    public decimal? InvAmountFc { get; set; }

    public decimal? InvAmountBc { get; set; }

    public string? FullyPaid { get; set; }

    public decimal? PaidAmtFc { get; set; }

    public decimal? PaidAmtBc { get; set; }
}
