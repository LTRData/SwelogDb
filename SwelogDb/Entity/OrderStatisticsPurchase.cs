using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderStatisticsPurchase
{
    public string? MarketCode { get; set; }

    public string? SalesmanCode { get; set; }

    public string? CustomerName { get; set; }

    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public DateTime? OrderDate { get; set; }

    public string? PartnerId { get; set; }

    public string? CurrencyCode { get; set; }

    public string? OurReference { get; set; }

    public string? TerritoryCode { get; set; }

    public string? DeliveryStatus { get; set; }

    public decimal PartnerDiscountPercentage { get; set; }

    public short OrderLineNumber { get; set; }

    public short OrderLineNumberSub { get; set; }

    public DateTime? PlannedDeliveryDate { get; set; }

    public string? ItemNumber { get; set; }

    public decimal OrderQuantity { get; set; }

    public string? UnitOfSale { get; set; }

    public decimal QuantityGenerated { get; set; }

    public string? UnitOfStock { get; set; }

    public decimal SellingPrice { get; set; }

    public decimal GrossOrderedAmount { get; set; }

    public decimal DiscountPercentage { get; set; }

    public decimal DiscountPercentage2 { get; set; }

    public decimal SetupPrice { get; set; }

    public decimal ActualDeliveredQuantity { get; set; }

    public string? SupplierName { get; set; }

    public decimal? CostPrice { get; set; }

    public string? ItemDescription { get; set; }

    public string? ProductGroup { get; set; }

    public string? ItemType2 { get; set; }

    public decimal? OrderedAmount { get; set; }

    public decimal CurrencyUnits { get; set; }

    public decimal? StandardExchangeRate { get; set; }

    public decimal? DeliveredAmt { get; set; }

    public decimal? DeliveredNetAmt { get; set; }

    public decimal? DeliveredAmtBc { get; set; }

    public decimal? UndeliveredButMarkedAmt { get; set; }

    public decimal? UndeliveredButMarkedAmtBc { get; set; }

    public decimal? UndeliveredButMarkedQty { get; set; }

    public decimal? OrderAmtBc { get; set; }

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

    public string? PartnerOwnOrderNo { get; set; }
}
