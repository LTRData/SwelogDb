using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderStatisticsWithCustomerReturn
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public DateTime? OrderDate { get; set; }

    public string? PartnerId { get; set; }

    public string? CurrencyCode { get; set; }

    public string? SalesmanCode { get; set; }

    public string? MarketCode { get; set; }

    public string? TerritoryCode { get; set; }

    public string? DeliveryStatus { get; set; }

    public decimal PartnerDiscountPercentage { get; set; }

    public short? OrderLineNumber { get; set; }

    public int OrderLineNumberSub { get; set; }

    public DateTime? PlannedDeliveryDate { get; set; }

    public string? ItemNumber { get; set; }

    public double? OrderQuantity { get; set; }

    public string? UnitOfSale { get; set; }

    public double? QuantityGenerated { get; set; }

    public string? UnitOfStock { get; set; }

    public decimal SellingPrice { get; set; }

    public double? GrossOrderedAmount { get; set; }

    public decimal DiscountPercentage { get; set; }

    public decimal DiscountPercentage2 { get; set; }

    public decimal SetupPrice { get; set; }

    public double ActualDeliveredQuantity { get; set; }

    public string? CustomerName { get; set; }

    public decimal? CostPrice { get; set; }

    public string? ItemDescription { get; set; }

    public string? ProductGroup { get; set; }

    public string? ItemType2 { get; set; }

    public double? OrderedAmount { get; set; }

    public decimal CurrencyUnits { get; set; }

    public decimal? StandardExchangeRate { get; set; }

    public double? DeliveredAmt { get; set; }

    public double? DeliveredNetAmt { get; set; }

    public double? DeliveredAmtBc { get; set; }

    public double? UndeliveredButMarkedAmt { get; set; }

    public double? UndeliveredButMarkedAmtBc { get; set; }

    public double? UndeliveredButMarkedQty { get; set; }

    public double? OrderAmtBc { get; set; }

    public DateTime? LastDeliveredDate { get; set; }

    public DateTime? PromisedDeliveryDate { get; set; }

    public int? NoOfWorkingdays { get; set; }

    public int? WorkdayDelay { get; set; }

    public string? OrderLineType { get; set; }

    public DateTime? DesiredDeliveryDate { get; set; }

    public int? PromiseDelay { get; set; }

    public string? OrderStatus { get; set; }

    public int? PriceUnit { get; set; }

    public decimal? VatPercentage { get; set; }

    public string? WhichLine { get; set; }

    public int? PriceUnitNum { get; set; }
}
