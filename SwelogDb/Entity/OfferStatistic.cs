using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OfferStatistic
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public DateTime? OrderDate { get; set; }

    public string? PartnerId { get; set; }

    public string? CurrencyCode { get; set; }

    public string? SalesmanCode { get; set; }

    public string? Salesman { get; set; }

    public string? MarketCode { get; set; }

    public string? TerritoryCode { get; set; }

    public decimal? OfferSuccessRate { get; set; }

    public DateTime? OrderValidDate { get; set; }

    public DateTime? ConfirmationDate { get; set; }

    public string? OrderStatus { get; set; }

    public string? DeliveryStatus { get; set; }

    public decimal PartnerDiscountPercentage { get; set; }

    public short OrderLineNumber { get; set; }

    public short OrderLineNumberSub { get; set; }

    public DateTime PlannedDeliveryDate { get; set; }

    public string? ItemNumber { get; set; }

    public decimal OrderQuantity { get; set; }

    public string? UnitOfSale { get; set; }

    public decimal QuantityGenerated { get; set; }

    public string? UnitOfStock { get; set; }

    public decimal SellingPrice { get; set; }

    public decimal GrossOrderedAmount { get; set; }

    public decimal DiscountPercentage { get; set; }

    public decimal SetupPrice { get; set; }

    public decimal ActualDeliveredQuantity { get; set; }

    public string? CustomerName { get; set; }

    public decimal CostPrice { get; set; }

    public string? ItemDescription { get; set; }

    public string? ProductGroup { get; set; }

    public decimal? OrderedAmount { get; set; }

    public decimal CurrencyUnits { get; set; }

    public decimal? StandardExchangeRate { get; set; }

    public decimal? DeliveredAmt { get; set; }

    public decimal? DeliveredNetAmt { get; set; }

    public decimal? DeliveredAmtBc { get; set; }

    public decimal? OrderAmtBc { get; set; }

    public DateTime? LastDeliveredDate { get; set; }

    public DateTime? PromisedDeliveryDate { get; set; }

    public short? WeekNo { get; set; }

    public short? Year { get; set; }

    public string? ProductGroupDescription { get; set; }

    public string? Datemask { get; set; }

    public string? SalesUomFormat { get; set; }

    public string? StockUomFormat { get; set; }

    public string? OrderCurrencyFormat { get; set; }

    public string? BaseCurrencyFormat { get; set; }
}
