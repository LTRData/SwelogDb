using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PurchaseOrderDependent
{
    public string? CustomerId { get; set; }

    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public short OrderLineNumber { get; set; }

    public short OrderLineNumberSub { get; set; }

    public string DeliveryAddressId { get; set; } = null!;

    public string? OrderLineType { get; set; }

    public string? ItemNumber { get; set; }

    public decimal? SellingPrice { get; set; }

    public string? GoodsDescription { get; set; }

    public decimal? OrderQuantity { get; set; }

    public string? UnitOfSale { get; set; }

    public string? DirectDeliveryFlag { get; set; }

    public DateTime DesiredDeliveryDate { get; set; }

    public string? SupplierId { get; set; }

    public string PurchaseOrderNumber { get; set; } = null!;

    public string? CurrencyCode { get; set; }

    public decimal? PartnerDiscountPercentile { get; set; }

    public DateTime PlannedDeliveryDate { get; set; }

    public short PurchaseOrderLine { get; set; }

    public decimal? PurchaseQty { get; set; }

    public string? PurchaseUnit { get; set; }

    public decimal? QuantityGenerated { get; set; }

    public string? UnitOfStock { get; set; }

    public decimal? PurchasePrice { get; set; }

    public decimal? SetupPrice { get; set; }

    public short? PriceUnit { get; set; }

    public decimal? DiscountPercentage { get; set; }

    public string? DeliveryNote { get; set; }

    public decimal? InvoiceQty { get; set; }
}
