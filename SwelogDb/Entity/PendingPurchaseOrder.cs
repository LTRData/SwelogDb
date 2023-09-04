using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PendingPurchaseOrder
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public DateTime? OrderDate { get; set; }

    public string? PartnerId { get; set; }

    public decimal? OrderDiscountPercent { get; set; }

    public string? CurrencyCode { get; set; }

    public short OrderLineNumber { get; set; }

    public short OrderLineNumberSub { get; set; }

    public DateTime PlannedDeliveryDate { get; set; }

    public DateTime? ActualDeliveryDate { get; set; }

    public string? ItemNumber { get; set; }

    public string? ItemDescription { get; set; }

    public decimal OrderQuantity { get; set; }

    public string? UnitOfSale { get; set; }

    public decimal? QuantityGenerated { get; set; }

    public string? UnitOfStock { get; set; }

    public decimal? SellingPrice { get; set; }

    public short PriceUnit { get; set; }

    public decimal CurrencyUnits { get; set; }

    public decimal OrderedAmount { get; set; }

    public decimal ActualDeliveredQuantity { get; set; }

    public decimal SetupPrice { get; set; }

    public decimal? WaitingDeliveries { get; set; }

    public decimal? NetSellingPriceBc { get; set; }

    public decimal ActualApprovedQuantity { get; set; }

    public string? SupplierName { get; set; }

    public decimal? StandardExchangeRate { get; set; }

    public decimal? WaitingAmtBc { get; set; }

    public short? WeekNo { get; set; }

    public short? YearNo { get; set; }

    public string DeliveryStatus { get; set; } = null!;
}
