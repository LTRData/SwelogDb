using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderStatisticsOnlyHeader
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public DateTime? OrderDate { get; set; }

    public string? PartnerId { get; set; }

    public string? CurrencyCode { get; set; }

    public string? SalesmanCode { get; set; }

    public string? MarketCode { get; set; }

    public string? TerritoryCode { get; set; }

    public decimal PartnerDiscountPercentage { get; set; }

    public string? CustomerName { get; set; }

    public decimal CurrencyUnits { get; set; }

    public decimal? StandardExchangeRate { get; set; }

    public DateTime? OrderConfirmDate { get; set; }

    public int? ConfirmationDelay { get; set; }
}
