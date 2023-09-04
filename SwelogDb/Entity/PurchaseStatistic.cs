using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PurchaseStatistic
{
    public string OrderType { get; set; } = null!;

    public string? OrderNumber { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime ArrivalDate { get; set; }

    public string? PartnerId { get; set; }

    public decimal OrderDiscountPercent { get; set; }

    public string? CurrencyCode { get; set; }

    public string? OurReference { get; set; }

    public short OrderLineNumber { get; set; }

    public short OrderLineNumberSub { get; set; }

    public DateTime PlannedDeliveryDate { get; set; }

    public DateTime ActualDeliveryDate { get; set; }

    public string? ItemNumber { get; set; }

    public decimal OrderQuantity { get; set; }

    public string? UnitOfSale { get; set; }

    public decimal QuantityGenerated { get; set; }

    public string? UnitOfStock { get; set; }

    public decimal SellingPrice { get; set; }

    public short PriceUnit { get; set; }

    public decimal OrderedAmount { get; set; }

    public decimal DiscountPercentage { get; set; }

    public decimal SetupPrice { get; set; }

    public decimal ActualDeliveredQuantity { get; set; }

    public decimal ActualApprovedQuantity { get; set; }

    public string? SupplierName { get; set; }

    public decimal CostPrice { get; set; }

    public decimal CostpriceAfterInvoice { get; set; }

    public string? ItemDescription { get; set; }

    public string? ProductGroup { get; set; }

    public string? ProductGroupDescription { get; set; }

    public decimal CurrencyUnits { get; set; }

    public decimal? StandardExchangeRate { get; set; }

    public decimal? DeliveredAmtBc { get; set; }

    public decimal? DeliveredAmtFc { get; set; }

    public decimal UnitPrice { get; set; }

    public string GoodsentryNo { get; set; } = null!;

    public string? DeliveryAddressId { get; set; }

    public string? DeliveryStatus { get; set; }

    public DateTime? LastDeliveredDate { get; set; }

    public DateTime? AvailableDate { get; set; }

    public int? WorkdayDelay { get; set; }
}
